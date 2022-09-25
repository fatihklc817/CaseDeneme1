using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Behaviours;

namespace Game.Scripts.Behaviours
{

    public class ObjectBehaviour : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _forcePower;

        private bool _istriggeredOnce;

        public void AddForceToObject()
        {
            _rigidbody.AddForce(Vector3.forward * _forcePower);
        }


        private void OnTriggerEnter(Collider other)
        {
            

                if (other.CompareTag("TargetArea"))
                {
                    if (!_istriggeredOnce)
                    { 
                        other.GetComponent<TargetAreaBehaviour>().IncreaseObjectCounter();
                        _istriggeredOnce = true;
                    }
                }
        }


    }
}
