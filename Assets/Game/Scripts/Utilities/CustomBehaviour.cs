using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Managers;


namespace Game.Scripts.Utilities
{
    public class CustomBehaviour : MonoBehaviour
    {
        public GameManager GameManager { get; set; }


        public virtual void Initialize(GameManager gameManager)
        {
            GameManager = gameManager;
        }


    }
}
