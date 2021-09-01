using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StroyMenu : MonoBehaviour
{
    
    public void StoryMode ()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void TrainingMode ()
    {
        //SceneManager.LoadScene("Training Ground");
    }

    public void BackToMain ()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
