using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Utilities;
using Game.Scripts.Managers;
using Game.Scripts.Behaviours;

namespace Game.Scripts.Controllers
{
    public class PickerController : CustomBehaviour
    {
        public PickerTargetAreaDetector TargetAreaDetector => _pickerTargetAreaDetector;
        public PickerMovementBehaviour PickerMovementBehaviour => _pickerMovementBehaviour;

        [SerializeField] PickerMovementBehaviour _pickerMovementBehaviour;
        [SerializeField] PickerTargetAreaDetector _pickerTargetAreaDetector;

        public override void Initialize(GameManager gameManager)
        {
            base.Initialize(gameManager);
            _pickerMovementBehaviour.Initialize(this);
            _pickerTargetAreaDetector.Initialize(this);
                    
        }
    }
}
