using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Controllers;
using Game.Scripts.Behaviours;
using Game.Scripts.Managers;


public class LevelBehaviour : MonoBehaviour
{
    public PickerController PickerController => _pickerController;
    public TargetAreaBehaviour TargetAreaBehaviour => _targetAreaBehaviour;

    [SerializeField] PickerController _pickerController;
    [SerializeField] TargetAreaBehaviour _targetAreaBehaviour;

    public void Initialize(GameManager gameManager)
    {
        _pickerController.Initialize(gameManager);
    }
}
