using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGun : MonoBehaviour
{
    [SerializeField] private Look _gun;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _gun.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _gun.enabled = false;
        }
    }

}
