using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakosCollision : MonoBehaviour
{
    public KakosMovement movement;
    public AudioSource source;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            movement.enabled = false;
            source.enabled = false;


        }
    }
}
