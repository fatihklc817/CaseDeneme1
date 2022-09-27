using Game.Scripts.Managers;
using Game.Scripts.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Game.Scripts.Data;

public class InGamePanel : UIPanel
{
    [SerializeField] TextMeshProUGUI LevelIDTextMesh;


    public override void Initialize(UIManager uiManager)
    {
        base.Initialize(uiManager);
        GameManager.EventManager.OnStartPanelInput += ShowPanel;
        GameManager.EventManager.OnStartGame += UpdateIdMesh;
    }
    private void OnDestroy()
    {
        GameManager.EventManager.OnStartPanelInput -= ShowPanel;
        GameManager.EventManager.OnStartGame -= UpdateIdMesh;
    }

    public override void ShowPanel()
    {
        base.ShowPanel();
       
    }

    public override void HidePanel()
    {
        base.HidePanel();
    }

    public void UpdateIdMesh()
    {
        LevelIDTextMesh.text =("Level " + PlayerData.CurrentLevelID.ToString());
    }

}

