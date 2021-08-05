using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger2less : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene("Death 02 less");
        }
    }
}
