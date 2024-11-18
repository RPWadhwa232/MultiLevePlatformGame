using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace YourNamespace { 
  public class SettingsUI : MonoBehaviour
    {
        public GameObject settingsPanel;

        public void OpenSettings()
        {
            Debug.Log("Open Settings");
            settingsPanel.SetActive(true);
        }

        public void CloseSettings()
        {
            settingsPanel.SetActive(false);
        }
    }
}

