using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMover : MonoBehaviour
{
    [SerializeField] Transform start, end;
    [SerializeField] float speed;

    [SerializeField, Range(0,1)] float startPosition;

    Transform nextTarget;

    void Start()
    {
        nextTarget = end; 
    }
    void Update()
    {   
        Vector3 self = transform.position;
        Vector3 target = nextTarget.position;

        transform.position = Vector3.MoveTowards(self, target, speed * Time.deltaTime);

        if (transform.position == target)
        {  
            nextTarget = nextTarget ==start ? end : start;
        }
    }

    void OnValidate()
    {
        transform.position = Vector3.Lerp(start.position, end.position, startPosition);    
    }



    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(start.position, 0.25f);
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(end.position, 0.25f);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(start.position, end.position);
    }
}
