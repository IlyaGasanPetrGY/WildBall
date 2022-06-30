using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladMail : Bariers
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Killer();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Killer();
        }
    }
}
