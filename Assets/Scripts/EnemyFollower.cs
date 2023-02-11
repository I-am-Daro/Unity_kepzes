using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    [SerializeField] Transform target;

    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;
        Vector3 direction = targetPosition - selfPosition;

        //Vector3 direction = targetPosition - selfPosition;
        //direction.Normalize();

        //Vector3 velocity = direction * speed;
        //transform.position += velocity * Time.deltaTime;

        transform.position = Vector3.MoveTowards(selfPosition, targetPosition, speed *Time.deltaTime);
        if (direction !=Vector3.zero)
            transform.rotation = Quaternion.LookRotation(direction);
    }
}
