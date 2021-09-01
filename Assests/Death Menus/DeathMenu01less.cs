using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu01less : MonoBehaviour
{

    public void Start ()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void SceneChange ()
    {
        SceneManager.LoadScene("Level 01 less");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
