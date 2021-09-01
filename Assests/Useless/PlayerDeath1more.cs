using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath1more : MonoBehaviour
{

    public PlayerHealth player;

    public void Action ()
    {
        if (player.currentHealth <= 0)
        {
            Debug.Log("Dead");
        }
    }


}
