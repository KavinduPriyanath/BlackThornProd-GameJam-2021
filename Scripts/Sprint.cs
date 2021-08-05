using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    public PlayerMovement movement;

    public float speedBoost;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movement.speed += speedBoost;
        } else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movement.speed -= speedBoost;
        }
    }
}
