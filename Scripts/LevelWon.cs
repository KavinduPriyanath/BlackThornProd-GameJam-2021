using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelWon : MonoBehaviour
{
    
    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene("Victory");
        }
    }

}
