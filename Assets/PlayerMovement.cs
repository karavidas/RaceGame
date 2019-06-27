using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed;
    private float vrRoll;

    void Update()
    {
        float vrRoll = Camera.main.transform.eulerAngles.z;
        transform.position = transform.position + transform.forward * playerSpeed * Time.deltaTime;

         if (vrRoll >= (10) && vrRoll<=(80))
        {
            transform.Translate(0.1f, 0f, 0f);
        }

        if (vrRoll <= (350) && vrRoll >= (280))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
    }
}
