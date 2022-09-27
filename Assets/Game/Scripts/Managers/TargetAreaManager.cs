using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Utilities;
using Game.Scripts.Behaviours;

namespace Game.Scripts.Managers
{
    public class TargetAreaManager : CustomBehaviour
    {
        public TargetAreaBehaviour TargetAreaBehaviour;
        public TargetAreaPanel TargetAreaPanel;
        

        public override void Initialize(GameManager gameManager)
        {
            base.Initialize(gameManager);            
        }

        public void SetTargetArea()
        {
            TargetAreaBehaviour = GameManager.LevelManager.CurrentLevel.TargetAreaBehaviour;
            TargetAreaPanel = GameManager.LevelManager.CurrentLevel.TargetAreaPanel;
            TargetAreaBehaviour.Initialize(this);
            TargetAreaPanel.Initialize(TargetAreaBehaviour.ObjectCount, TargetAreaBehaviour.AreaTargetCount);
        }




    }
}
