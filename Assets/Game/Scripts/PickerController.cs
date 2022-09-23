using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerController : MonoBehaviour
{
    [SerializeField] private float _forwardMoveSpeed;
    [SerializeField] private float _horizontalMoveSpeed;

    void Start()
    {
        
    }

   
    void FixedUpdate()
    {

        transform.position = transform.position + Vector3.forward * Time.deltaTime * _forwardMoveSpeed;
        


        if (Input.GetMouseButton(0))
        {
            

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit,100f))
            { 
                 Debug.DrawRay(ray.origin,ray.direction*100f, Color.white);
                if (hit.transform.CompareTag("floor"))
                {
                    Vector3 hitVector = hit.point;
                    Vector3 targetPos = new Vector3(hitVector.x, transform.position.y, transform.position.z);

                    transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * _horizontalMoveSpeed);
                }
            }
        }
        
    }
}
