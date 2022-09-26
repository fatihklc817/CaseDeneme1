using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Utilities;
using Game.Scripts.UI;

namespace Game.Scripts.Managers
{

    public class UIManager : CustomBehaviour
    {
        [SerializeField] UIPanel _successPanel;
        [SerializeField] UIPanel _failPanel;

        private List<UIPanel> UIPanels;



        public override void Initialize(GameManager gameManager)
        {
            base.Initialize(gameManager);
            UIPanels = new List<UIPanel> {_successPanel,_failPanel };
            for (int i = 0; i < UIPanels.Count; i++)
            {
                UIPanels[i].Initialize(this);
            }
        }



    }

}