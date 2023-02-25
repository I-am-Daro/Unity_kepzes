using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotator : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180f;
    void Update()
    {
        transform.Rotate(0, angularSpeed * Time.deltaTime, 0);
    }
}
