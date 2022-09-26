using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Controllers;
using Game.Scripts.Behaviours;

public class LevelBehaviour : MonoBehaviour
{
    public PickerController PickerController => _pickerController;
    public TargetAreaBehaviour TargetAreaBehaviour => _targetAreaBehaviour;

    [SerializeField] PickerController _pickerController;
    [SerializeField] TargetAreaBehaviour _targetAreaBehaviour;
}
