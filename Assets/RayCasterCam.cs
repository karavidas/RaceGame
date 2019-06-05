using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasterCam : MonoBehaviour
{
    public int distance;
    private RaycastHit _hit;
    public ChangeScene change;

    void FixedUpdate()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if (Physics.Raycast(ray,out _hit, distance))
        {
            if (Input.GetButtonDown("Fire1") && _hit.transform.CompareTag("StartCube"))
                change.StartGame();
        }
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        //if (Physics.Raycast(transform.position, fwd, 10))
    }
}
