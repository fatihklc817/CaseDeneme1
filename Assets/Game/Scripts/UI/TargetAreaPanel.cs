using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TargetAreaPanel : MonoBehaviour
{
    [SerializeField] private TextMeshPro _counterTextMesh;
    private int _objectCount;
    private int _areaTargetCount;
   
    public void Initialize(int objectCount , int areaTargetCount)
    {
        _objectCount = objectCount;
        _areaTargetCount = areaTargetCount;
        _counterTextMesh.text = _objectCount.ToString() + (" / ") + _areaTargetCount;
    }

    public void PopulateView(int objectCount)
    {
        _objectCount = objectCount;
        _counterTextMesh.text = _objectCount.ToString() + (" / ") + _areaTargetCount;
    }
}
