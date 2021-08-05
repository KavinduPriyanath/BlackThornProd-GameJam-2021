using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickUp : MonoBehaviour
{
    public Animator animator;

    public Gun gunScript;

    public Rigidbody rb;

    public BoxCollider col;

    public Transform player, gunContainer, fpsCam;

    public float pickUpRange;

    public float dropForwardForce, dropUpwardForce;

    public bool equipped;

    public static bool slotFull;

    void Start ()
    {
        if (!equipped)
        {
            animator.enabled = false;
            gunScript.enabled = false;
            rb.isKinematic = false;
            col.isTrigger = false;
        }
        if (equipped)
        {
            animator.enabled = true;
            gunScript.enabled = true;
            rb.isKinematic = true;
            col.isTrigger = true;
            slotFull = true;
        }
    }

    void Update ()
    {
        Vector3 distanceToPlayer = player.position - transform.position;

        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull)
            PickUp();
        if (equipped && Input.GetKeyDown(KeyCode.Q))
            Drop();
    }

    void PickUp ()
    {
        equipped = true;
        slotFull = true;

        transform.SetParent(gunContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;

        rb.isKinematic = true;
        col.isTrigger = true;
        gunScript.enabled = true;
        animator.enabled = true;
    }

    void Drop ()
    {
        equipped = false;
        slotFull = false;

        transform.SetParent(null);
        rb.isKinematic = false;
        col.isTrigger = false;

        rb.velocity = player.GetComponent<Rigidbody>().velocity;
        rb.AddForce(fpsCam.forward * dropForwardForce, ForceMode.Impulse);
        rb.AddForce(fpsCam.up * dropUpwardForce, ForceMode.Impulse);
        float random = Random.Range(-1f, 1f);
        rb.AddTorque(new Vector3(random, random, random) * 10);
        gunScript.enabled = false;
        animator.enabled = false;
    }


}
