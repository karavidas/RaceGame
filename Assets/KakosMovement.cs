using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakosMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce;
    private float distanceToCull = 5f;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, -ForwardForce * Time.deltaTime);
        DestroyCar();
    }

    private void DestroyCar ()
    {
        var cameraPosition = Camera.main.transform.position;
        var vectorToItem = (rb.position - cameraPosition);
        if (Vector3.Angle(vectorToItem, Camera.main.transform.forward) > 90) //It's behind us
        {
            //Perhaps ensure it's far enough away
            if (vectorToItem.sqrMagnitude > distanceToCull * distanceToCull)
            {
                Destroy(gameObject);
            }
        }
    }
}
