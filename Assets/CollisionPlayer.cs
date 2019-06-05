using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionPlayer : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioSource soundsource;
    public bool kopanise = false;
    public bool trakare = false;
    public Score score;
    public GameObject canvas;
    private float timer = 0;
    private float timerMax = 0;

    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Rock" || collisionInfo.collider.tag == "Kakos" || collisionInfo.collider.tag == "Lamp")
        {
            trakare = true;
            movement.enabled = false;
            canvas.SetActive(true);
            PlayerPrefs.SetString("Game", "restart");
        }

        if (collisionInfo.collider.tag == "Chast")
        {
            soundsource.Play();
            kopanise = true;
        }
    }

}
