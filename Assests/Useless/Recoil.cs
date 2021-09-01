using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour
{
    public Vector3 upRecoil;
    Vector3 originalRotation;

    void Start()
    {
        originalRotation = transform.localEulerAngles;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            AddRecoil();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            StopRecoil();
        }
    }

    

    private void AddRecoil()
    {
        transform.localEulerAngles += upRecoil;
    }

    private void StopRecoil()
    {
        transform.localEulerAngles = originalRotation;
    }
}
