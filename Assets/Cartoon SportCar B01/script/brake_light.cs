using UnityEngine;
using System.Collections;

public class brake_light : MonoBehaviour
{
    public Light[] lights;

    void Start()
    {
        foreach (Light light in lights)
        {
            light.enabled = !light.enabled;
        }
    }
}

