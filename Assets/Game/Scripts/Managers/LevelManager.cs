using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Utilities;
using Game.Scripts.Managers;
using Game.Scripts.Data;
using Game.Scripts.Behaviours;
using System;

namespace Game.Scripts.Managers
{
    public class LevelManager : CustomBehaviour
    {
        

        private LevelBehaviour _currentLevel;
        
        
        public override void Initialize(GameManager gameManager)
        {
            base.Initialize(gameManager);
            GameManager.EventManager.OnStartGame += StartGame;
        }

        private void OnDestroy()
        {
            GameManager.EventManager.OnStartGame -= StartGame;
        }

        private void StartGame()
        {
            ClearLevel();

            Resources.UnloadUnusedAssets();

            int levelcount = PlayerData.CurrentLevelID;

            LevelBehaviour levelBehaviourPrefab = Resources.Load<LevelBehaviour>("Levels/Level" + levelcount);

            LevelBehaviour levelBehaviour = Instantiate(levelBehaviourPrefab);

            GameManager.PickerController = levelBehaviour.PickerController;
            GameManager.TargetAreaManager.TargetAreaBehaviour = levelBehaviour.TargetAreaBehaviour;

            _currentLevel = levelBehaviour;
        }


        private void ClearLevel()
        {
            if (_currentLevel != null)
            {
                Destroy(_currentLevel.gameObject);
            }
        }

        public void ContinueToNextLevel()
        {
            PlayerData.CurrentLevelID += 1;
            StartGame();
        }

        public void RetryCurrentLevel()
        {
            StartGame();
        }



    }
}