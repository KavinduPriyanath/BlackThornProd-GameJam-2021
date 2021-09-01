using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu02more : MonoBehaviour
{

    public void Start ()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void SceneChange ()
    {
        SceneManager.LoadScene("Level 02 more");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
