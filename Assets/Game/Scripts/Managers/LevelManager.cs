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
        public LevelBehaviour CurrentLevel => _currentLevel;

        private LevelBehaviour _currentLevel;
        private int _totalLevelCount;

        public override void Initialize(GameManager gameManager)
        {
            base.Initialize(gameManager);
            GameManager.EventManager.OnStartGame += StartGame;
            _totalLevelCount = Resources.LoadAll<LevelBehaviour>("Levels").Length;
           
        }

        private void OnDestroy()
        {
            GameManager.EventManager.OnStartGame -= StartGame;
        }

        private void StartGame()
        {
            ClearLevel();

            Resources.UnloadUnusedAssets();

            


            var currentLevelCount = PlayerData.CurrentLevelID;

            int totalLevelLapIncrementValue = 0;

            if (currentLevelCount > _totalLevelCount)
            {
                totalLevelLapIncrementValue = 5 * ((currentLevelCount - 5) / (_totalLevelCount - 5));
            }

            var lapValue = (currentLevelCount + totalLevelLapIncrementValue) / _totalLevelCount;

            if (currentLevelCount >= _totalLevelCount)
            {
                currentLevelCount -= (_totalLevelCount * lapValue);
            }

            currentLevelCount = lapValue >= 1 ? currentLevelCount + (5 * lapValue) : currentLevelCount;



            LevelBehaviour levelBehaviourPrefab = Resources.Load<LevelBehaviour>("Levels/Level" + currentLevelCount);

            LevelBehaviour levelBehaviour = Instantiate(levelBehaviourPrefab);

            _currentLevel = levelBehaviour;

            _currentLevel.Initialize(GameManager);

            GameManager.TargetAreaManager.SetTargetArea();
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
            GameManager.EventManager.StartGame();
        }

        public void RetryCurrentLevel()
        {
            GameManager.EventManager.StartGame();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                GameManager.EventManager.LevelSucceed();
            }
        }




    }
}