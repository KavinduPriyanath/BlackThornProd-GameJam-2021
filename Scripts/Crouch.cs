using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public CapsuleCollider player;

    float originalHeight;

    public float reducedHeight;

    void Start ()
    {
        originalHeight = player.height;
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
            Croulch();
        else if (Input.GetKeyUp(KeyCode.LeftControl))
            GotUp();
    }

    void Croulch ()
    {
        player.height = reducedHeight;
    }

    void GotUp()
    {
        player.height = originalHeight;
    }
}
