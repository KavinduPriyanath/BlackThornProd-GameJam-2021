using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceStopper : MonoBehaviour
{
    public AudioSource voiceCut;

    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            voiceCut.Stop();
            Destroy(gameObject);
        }
    }
}
