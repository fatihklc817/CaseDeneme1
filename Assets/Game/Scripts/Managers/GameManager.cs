using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Utilities;
using Game.Scripts.Managers;
using Game.Scripts.Controllers;

namespace Game.Scripts.Managers
{

    public class GameManager : CustomBehaviour
    {
        public EventManager EventManager;
        public UIManager UIManager;
        public LevelManager LevelManager;
        public TargetAreaManager TargetAreaManager;
        



        private void Awake()
        {
            LevelManager.Initialize(this);
            EventManager.Initialize(this);
            UIManager.Initialize(this);
            TargetAreaManager.Initialize(this);
            
        }

        private void Start()
        {
            EventManager.StartGame();
        }
    }
}