using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level02less : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Player")
        {
            SceneManager.LoadScene("Level 02 less");
        }
    }
}
