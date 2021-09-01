using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 25f;

    public float range = 10f;

    public Camera fpsCam;

    public Animator animator;

    private bool isAttack = false;

    public AudioSource attackSound;

    void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            isAttack = !isAttack;
            animator.SetBool("Attack", isAttack);
            attackSound.Play();
            
        }  else if (Input.GetButtonUp("Fire1"))
        {
            isAttack = !isAttack;
            animator.SetBool("Attack", isAttack);
        }
        
    }

    void Shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }

    


}
