using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.UI;
using Game.Scripts.Managers;

namespace Game.Scripts.UI
{
    public class SuccessPanel : UIPanel
    {


        public override void Initialize(UIManager uiManager)
        {
            base.Initialize(uiManager);

            GameManager.EventManager.OnLevelSucceed += ShowPanel;
            GameManager.EventManager.OnStartGame += HidePanel;
        }

        private void OnDestroy()
        {
            GameManager.EventManager.OnLevelSucceed -= ShowPanel;
            GameManager.EventManager.OnStartGame -= HidePanel;
        }

        public override void ShowPanel()
        {
            base.ShowPanel();

        }

        public override void HidePanel()
        {
            base.HidePanel();
        }



    }
}