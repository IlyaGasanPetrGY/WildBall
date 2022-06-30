using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    [SerializeField] private GameObject _boom;
    [SerializeField] private GameObject _ide;
    private Animator _anim;
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        _anim.SetBool("Collect", true);
    }
    public void CollectCoin()
    {
        Destroy(_ide);
        _boom.SetActive(true);
        Destroy(_ide);
        Destroy(_boom);
        Destroy(gameObject,0.5f);
    }
}
