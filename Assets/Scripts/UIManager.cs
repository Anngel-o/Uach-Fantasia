using UnityEngine.UI;
using UnityEngine;
using System;

public class UIManager : MonoBehaviour
{
    public GameObject mainPanel, optionsPanel;
    
    public void ActivePanel(GameObject panel){
        panel.SetActive(true);
    }

    public void DesactivePanel(GameObject panel){
        panel.SetActive(false);
    }

    void Start()
    {
        mainPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }
}
