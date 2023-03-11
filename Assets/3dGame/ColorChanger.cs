using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] Light light;
    [SerializeField] Color color1, color2;
    [SerializeField] float frequency = 1f;

    void Update()
    {
        float t = Mathf.Sin(Time.time * 2 * Mathf.PI * frequency);
        t += 1;
        t /= 2;


        Color c = Color.Lerp(color1, color2, t);

        light.color = c;
    }
}
