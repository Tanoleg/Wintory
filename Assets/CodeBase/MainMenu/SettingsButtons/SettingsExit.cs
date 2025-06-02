using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsExit : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;
    public void Exit()
    {
        Destroy(_settingsPanel);
    }
}
