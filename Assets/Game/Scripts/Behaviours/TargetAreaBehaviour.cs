using System.Collections;
using System.Collections.Generic;
using Game.Scripts.Managers;
using UnityEngine;
using TMPro;

namespace Game.Scripts.Behaviours
{

    public class TargetAreaBehaviour : MonoBehaviour
    {

        [SerializeField] private TextMeshPro _counterTextMesh;
        [SerializeField] private int _areaTargetCount;

        private int _objectCount;
        private TargetAreaManager _targetAreaManager;
        private Coroutine _checkObjectCounterCoroutine;


        public void Initialize(TargetAreaManager targetAreaManager)
        {
            _targetAreaManager = targetAreaManager;
            _counterTextMesh.text = _objectCount.ToString() + (" / ") + _areaTargetCount;
            _checkObjectCounterCoroutine = null;
            
        }



        public void IncreaseObjectCounter()
        {
            
            _objectCount++;
            _counterTextMesh.text = _objectCount.ToString() + (" / ") + _areaTargetCount;
            
              
            
        }

        public void StartCheckObjectCounterCo()
        {
            if (_checkObjectCounterCoroutine ==null)
            {
            _checkObjectCounterCoroutine =StartCoroutine(CheckObjectCounterCO());

            }
        }


        IEnumerator CheckObjectCounterCO()
        {
            yield return new WaitForSeconds(3);
            if (_objectCount < _areaTargetCount)
            {
                Debug.Log(_objectCount + _areaTargetCount);
                _targetAreaManager.GameManager.EventManager.LevelFailed();
            }
            else if (_objectCount >= _areaTargetCount)
            {
                Debug.Log((_objectCount) + (_areaTargetCount));
                _targetAreaManager.GameManager.EventManager.LevelSucceed();
            }
        }

    }
}
