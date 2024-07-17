using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject gamePanel;

    void showPanel(GameObject panelToShow) 
    { 
        startPanel.SetActive(false);
        gamePanel.SetActive(false);
        panelToShow.SetActive(true);
    }

    public void OnClickStartButton() 
    { 
        showPanel(gamePanel);
        GamePlayManager.instance.startSpawningTargets();
    }



}
