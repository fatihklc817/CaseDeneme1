using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    [SerializeField] private Transform _followingObject;

    private Camera _camera;
    private Vector3 _cameraOffset;
     private float _cameraLerpFloat = 0.5f;
   

    void Start()
    {
        _camera = Camera.main;
        _cameraOffset = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        Vector3 targetPos = new Vector3 (transform.position.x,transform.position.y,_followingObject.position.z)+ _cameraOffset;
        Vector3 SmoothTargetPos = Vector3.Lerp(transform.position, targetPos, _cameraLerpFloat) ;
        transform.position = SmoothTargetPos;
        
    }
}
