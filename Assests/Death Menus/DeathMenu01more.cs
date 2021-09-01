using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu01more : MonoBehaviour
{

    public void Start ()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void SceneChange ()
    {
        SceneManager.LoadScene("Level 01 more");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
