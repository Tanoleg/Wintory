using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationTest : MonoBehaviour
{
    [SerializeField] private NPCConversation _myConversation;
    private bool _end = false;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (_end == false)

            {
                ConversationManager.Instance.StartConversation(_myConversation);
                _end = true;
            }
        }
    }
}
