using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Controllers;
using Game.Scripts.Managers;

namespace Game.Scripts.Behaviours
{
    public class PickerTargetAreaDetector : MonoBehaviour
    {
        private PickerController _pickerController;

        public void Initialize(PickerController pickerController)
        {
            _pickerController = pickerController;
        }

        private void OnTriggerEnter(Collider other)
        {


            if (other.CompareTag("AreaPickerDetector"))
            {
                _pickerController.PickerMovementBehaviour.StopPicker();
                CheckMyInsideBox();
            }

        }

        private void CheckMyInsideBox()
        {
            Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, new Vector3(3.5f, 10, 5), Quaternion.identity);

            for (int i = 0; i < hitColliders.Length; i++)
            {
                if (hitColliders[i].gameObject.transform.CompareTag("Object"))
                {
                    hitColliders[i].gameObject.GetComponent<ObjectBehaviour>().AddForceToObject();


                }
            }
            _pickerController.GameManager.TargetAreaManager.TargetAreaBehaviour.StartCheckObjectCounterCo();

        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;

            if (true)

                Gizmos.DrawWireCube(transform.position, new Vector3(3.5f, 10, 5));
        }
    }
}
