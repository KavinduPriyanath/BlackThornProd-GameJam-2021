using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 3f;

    public void PlayGame ()
    {
        StartCoroutine(LoadLevel());
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    IEnumerator LoadLevel ()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene("Level Select");
    }

}
