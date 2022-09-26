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
        public TargetAreaManager TargetAreaManager;
        public PickerController PickerController;
        public LevelManager LevelManager;



        private void Awake()
        {
            EventManager.Initialize(this);
            UIManager.Initialize(this);
            LevelManager.Initialize(this);
            TargetAreaManager.Initialize(this);
            PickerController.Initialize(this);
        }

        private void Start()
        {
            EventManager.StartGame();
        }
    }
}