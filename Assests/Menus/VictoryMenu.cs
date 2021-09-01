using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    void Start ()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }


    public void QuitGame ()
    {
        Application.Quit();
    }
}
