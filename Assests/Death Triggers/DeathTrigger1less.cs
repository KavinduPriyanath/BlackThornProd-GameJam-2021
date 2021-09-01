using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger1less : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene("Death 01 less");
        }
    }
}
