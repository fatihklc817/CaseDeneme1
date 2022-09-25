using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Game.Scripts.Behaviours
{

    public class TargetAreaBehaviour : MonoBehaviour
    {

        [SerializeField] private TextMeshPro _counterTextMesh;
        [SerializeField] private int _areaTargetCount;

        private int _objectCount;


        private void Start()
        {
            _counterTextMesh.text = _objectCount.ToString() + (" / ") + _areaTargetCount;
        }

        public void IncreaseObjectCounter()
        {
            
            _objectCount++;
            _counterTextMesh.text = _objectCount.ToString() + (" / ") + _areaTargetCount;
        }

    }
}
