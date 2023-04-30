using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    [SerializeField] float acceleration = 5f;
    [SerializeField] float angularSpeed = 360f;
    [SerializeField] float drag = 1f;

    Vector2 velocity;

void Update()
{
    bool forward = Input.GetKey(KeyCode.UpArrow);
        if(forward)
        {
            velocity += (Vector2)transform.up * (acceleration * Time.deltaTime);
            
        }
        transform.position += (Vector3) (velocity * Time.deltaTime);

    velocity *= 1f -(drag * Time.deltaTime);

    float h = Input.GetAxis("Horizontal");
    transform.Rotate(Vector3.forward, -h * Time.deltaTime) 
}  
}
