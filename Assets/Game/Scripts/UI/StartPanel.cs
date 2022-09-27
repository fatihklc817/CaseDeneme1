using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.UI;
using Game.Scripts.Managers;
using UnityEngine.EventSystems;

namespace Game.Scripts.UI
{
    public class StartPanel : UIPanel , IPointerDownHandler
    {
        
        public override void Initialize(UIManager uiManager)
        {
            base.Initialize(uiManager);
            
        }

        public override void ShowPanel()
        {
            base.ShowPanel();
        }

        public override void HidePanel()
        {
            base.HidePanel();
        }
    

        public void OnPointerDown(PointerEventData eventData)
        {
            HidePanel();
            GameManager.EventManager.StartPanelInputDown();
            
            
            
        }
    }

}