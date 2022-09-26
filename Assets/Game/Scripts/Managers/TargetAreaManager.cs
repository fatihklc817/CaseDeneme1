using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Utilities;
using Game.Scripts.Behaviours;

namespace Game.Scripts.Managers
{
    public class TargetAreaManager : CustomBehaviour
    {
        public TargetAreaBehaviour TargetAreaBehaviour => _targetAreaBehaviour;
        [SerializeField] TargetAreaBehaviour _targetAreaBehaviour;

        public override void Initialize(GameManager gameManager)
        {
            base.Initialize(gameManager);
            _targetAreaBehaviour.Initialize(this);
            
        }




    }
}
