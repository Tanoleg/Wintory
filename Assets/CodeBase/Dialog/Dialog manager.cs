using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogmanager : MonoBehaviour
{
    [SerializeField] private string[] _lines;
    [SerializeField] private float _textSpeed;
    [SerializeField] private Text _dialogueText;

    [SerializeField] private int _index;

    private void Start()
    {
        _dialogueText.text = string.Empty;
    }

    void StartDialogue()
    {
        _index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach(char c in _lines[_index].ToCharArray())
        {
            _dialogueText.text += c;
            yield return new WaitForSeconds(_textSpeed);
        }
    }

    public void scipTextClock()
    {
        if (_dialogueText.text == _lines[_index])
        {
            NextLines();
        }
        else
        {
            StopAllCoroutines();
            _dialogueText.text = _lines[_index];
        }
    }

    public void NextLines()
    {
        if(_index < _lines.Length - 1)
        {
            _index++;
            _dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}

