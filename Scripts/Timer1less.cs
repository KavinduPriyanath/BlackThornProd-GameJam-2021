using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer1less : MonoBehaviour
{
    public TMP_Text textDisplay;
    public int secondsLeft = 90;
    public bool takingAway = false;

    void Start ()
    {
        textDisplay.GetComponent<TMP_Text>().text = secondsLeft + " Secs";
    }

    void Update ()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimeTake());
        } else if (secondsLeft <= 0)
        {
            SceneManager.LoadScene("Death 01 less");
        }
    }

    IEnumerator TimeTake ()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<TMP_Text>().text = secondsLeft + " Secs";
        takingAway = false;
    }
}
