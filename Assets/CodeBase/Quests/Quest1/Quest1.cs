using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest1 : MonoBehaviour
{
    [SerializeField] private Text _questNameUI;
    [SerializeField] private Text _questDescriptionUI;

    [SerializeField] private string _questName;
    [SerializeField] private string _questDescription;

    [SerializeField] private Quest2 _nextQuest;
    void Start()
    {
        Give();
    }

    private void Give()
    {
        _questNameUI.text = _questName;
        _questDescriptionUI.text = _questDescription;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _nextQuest.Give();
    }
}
