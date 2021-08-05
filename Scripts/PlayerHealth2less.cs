using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;


public class PlayerHealth2less : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public GameObject profile;

    public AudioSource playerHurt;



    void Start ()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    //void Update ()
    //{
       // if (Input.GetKeyDown(KeyCode.Return))
        //{
          //  TakeDamage(20);
        //}
   // }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Obstacle")
        {
            TakeDamage(20);
            playerHurt.Play();
            profile.SetActive(true);
            StartCoroutine(BackToNormal());

            if (currentHealth <= 0)
            {
                SceneManager.LoadScene("Death 02 less");
            }
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    IEnumerator BackToNormal ()
    {
        yield return new WaitForSeconds(1f);
        profile.SetActive(false);
    }

    //void PlayerDeath ()
    //{
        
    //}
}
