using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrashColl : MonoBehaviour
{
    public AudioSource soundsource;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            soundsource.Play();
            Debug.Log("kopanise");
        }
    }
}
