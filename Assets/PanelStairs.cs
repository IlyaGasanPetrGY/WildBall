using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelStairs : MonoBehaviour
{
    [SerializeField] private Rigidbody _bladmailRB;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _bladmailRB.gameObject.SetActive(true);
            _bladmailRB.isKinematic = false;
        }
    }
}
