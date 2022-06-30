using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator _anim;
    [SerializeField] private GameObject _helper;   

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _helper.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                _anim.SetTrigger("Open");
            }
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _helper.SetActive(false);
        }

    }
    
}
