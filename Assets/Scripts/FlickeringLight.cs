using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public Light _light;

    public float minTime;
    public float maxTime;
    public float timer;
    void Start()
    {
        timer = Time.time;
    }

    void Update()
    {
        FlickerLight();
    }

    void FlickerLight()
    {
        if (Time.time - timer > 1)
        {
            _light.enabled = !_light.enabled;
            timer = Time.time;
        }
    }
}
