using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Utilities;
using Game.Scripts.Managers;

namespace Game.Scripts.Managers
{

    public class GameManager : CustomBehaviour
    {
        public EventManager EventManager;
        public UIManager UIManager;
        public TargetAreaManager TargetAreaManager;



        private void Awake()
        {
            EventManager.Initialize(this);
            UIManager.Initialize(this);
            TargetAreaManager.Initialize(this);
        }

    }
}