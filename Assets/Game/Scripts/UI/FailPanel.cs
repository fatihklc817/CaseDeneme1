using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.UI;
using Game.Scripts.Managers;

namespace Game.Scripts.UI
{
    public class FailPanel : UIPanel
    {
        public override void Initialize(UIManager uiManager)
        {
            base.Initialize(uiManager);
            GameManager.EventManager.OnLevelFailed += LocalShowPanel;
        }

        private void OnDestroy()
        {
            GameManager.EventManager.OnLevelFailed -= LocalShowPanel;
        }

        public override void ShowPanel()
        {
            base.ShowPanel();
        }

        private void LocalShowPanel()
        {
            ShowPanel();
        }
    }
}
