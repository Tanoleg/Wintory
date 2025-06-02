using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsLogic : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;
    public void Open()
    {
        Instantiate(_settingsPanel);
    }
}
