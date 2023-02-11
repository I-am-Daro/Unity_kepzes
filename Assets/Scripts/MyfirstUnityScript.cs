using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyfirstUnityScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");
    }

    void Update()
    {
        Vector2 v1;
        v1 = new Vector2(2,4);

        Vector2 v2;
        v2 = new Vector2(4,5);

        float x = v1.x;

        float mag = v1.magnitude;
        Vector2 v1Norm = v1.normalized;
        v1.Normalize();

        float distance1 = (v1 - v2).magnitude;
        float distance2 = (v2 - v1).magnitude;


    }

}
