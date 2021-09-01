using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceCut3 : MonoBehaviour
{
    public AudioSource voiceCut;

    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            voiceCut.Play();
            Destroy(gameObject);
        }
    }

    
}
