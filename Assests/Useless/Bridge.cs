using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public Animator animator;

    private bool isLower = false;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isLower = !isLower;
            animator.SetBool("Down", isLower);
        }
    }

}
