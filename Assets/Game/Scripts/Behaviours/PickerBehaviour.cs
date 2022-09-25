﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Behaviours
{

    public class PickerBehaviour : MonoBehaviour
    {

        [SerializeField] private float _forwardMoveSpeed;
        [SerializeField] private float _horizontalMoveSpeed;

        
        private bool _isPickerAbleToMove = true;

  

        void FixedUpdate()
        {
            

            if (_isPickerAbleToMove)
            {

            transform.position = transform.position + Vector3.forward * Time.deltaTime * _forwardMoveSpeed;
            }



            if (Input.GetMouseButton(0))
            {


                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100f))
                {
                    Debug.DrawRay(ray.origin, ray.direction * 100f, Color.white);
                    if (hit.transform.CompareTag("floor") || hit.transform.CompareTag("Picker"))
                    {
                        
                        Vector3 targetPos = new Vector3(hit.point.x, transform.position.y, transform.position.z);

                        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * _horizontalMoveSpeed);
                    }
                }
            }

        }

        private void OnTriggerEnter(Collider other)
        {
         

            if (other.CompareTag("AreaPickerDetector"))
            {
                StopPicker();
                CheckMyInsideBox();
            }

        }

        private void CheckMyInsideBox()
        {
            Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position,new Vector3(5,10,5),Quaternion.identity);
            for (int i = 0; i < hitColliders.Length; i++)
            {
                if (hitColliders[i].gameObject.transform.CompareTag("Object"))
                {
                    hitColliders[i].gameObject.GetComponent<ObjectBehaviour>().AddForceToObject();
                    
                }
            }
        }
      

        public void StopPicker()
        {
            _isPickerAbleToMove = false;
        }



        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            //Check that it is being run in Play Mode, so it doesn't try to draw this in Editor mode
            if (true)
                //Draw a cube where the OverlapBox is (positioned where your GameObject is as well as a size)
                Gizmos.DrawWireCube(transform.position,new Vector3(5,10,5));
        }

    }
}