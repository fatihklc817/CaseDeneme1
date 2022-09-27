using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Utilities;
using Game.Scripts.Managers;
using System;

namespace Game.Scripts.Managers
{
    public class EventManager : CustomBehaviour
    {
        public event Action OnStartGame;
        public event Action OnLevelSucceed;
        public event Action OnLevelFailed;
        public event Action OnStartPanelInput;



        public override void Initialize(GameManager gameManager)
        {
            base.Initialize(gameManager);
        }



        public void StartGame()
        {
            OnStartGame?.Invoke();
        }


        public void LevelSucceed()
        {
            OnLevelSucceed?.Invoke();
        }

        public void LevelFailed()
        {
            OnLevelFailed?.Invoke();
        }

        public void StartPanelInputDown()
        {
            OnStartPanelInput?.Invoke();
        }

        

    }
}
