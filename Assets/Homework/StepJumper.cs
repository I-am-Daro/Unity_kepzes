using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepJumper : MonoBehaviour
{
    [SerializeField] Vector2 a, b;

    [SerializeField] int stepcount;
    [SerializeField] Vector2 step;

    void OnValidate()
    {
        Vector2 v = b - a;
        
        float lenght = v.magnitude;
        stepcount = Mathf.CeilToInt(lenght);
        step = v / stepcount;
    }
}
