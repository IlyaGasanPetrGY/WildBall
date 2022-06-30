using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bariers : MonoBehaviour
{
    private GameObject _player;
    public Rigidbody PlayerRB
    {
        get
        {
            return _player.GetComponent<Rigidbody>();
        }
        set
        {
            _player = value.gameObject;
        }
    }
    public Animator PlayerAnim
    {
        get
        {
            return _player.GetComponent<Animator>();
        }
        set
        {
            _player = value.gameObject;
        }
    }
    private void Awake()
    {
        PlayerRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }
    IEnumerator Kill()
    {
        
        PlayerRB.isKinematic = true;
        PlayerAnim.SetTrigger("Death");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Killer()
    {

        StartCoroutine(Kill());
    }
}
