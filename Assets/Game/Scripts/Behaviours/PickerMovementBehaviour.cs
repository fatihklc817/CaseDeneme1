using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Controllers;
using Game.Scripts.Managers;

namespace Game.Scripts.Behaviours
{
    public class PickerMovementBehaviour : MonoBehaviour
    {
        [SerializeField] private float _forwardMoveSpeed;
        [SerializeField] private float _horizontalMoveSpeed;

        private bool _isPickerAbleToMove;

        private PickerController _pickerController;



        public void Initialize(PickerController pickerController)
        {
            _pickerController = pickerController;
            _isPickerAbleToMove = false;
            
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _isPickerAbleToMove = true;
            }
        }


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


        public void StopPicker()
        {
            _isPickerAbleToMove = false;
        }

       

    }
}
