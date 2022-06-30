using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _dulo;
    bool flag;
    float timer;

    private void Start()
    {
        timer = Random.Range(0.5f, 1.5f);
    }
    private void Pusher()
    {
        
        Vector3 SpawnBtn = _dulo.position;
        Quaternion Spawn = _dulo.rotation;
        
        GameObject Pula = Instantiate(_bullet, SpawnBtn, Spawn);
        Destroy(Pula,1f);
        Pula.GetComponent<Rigidbody>().AddForce(Pula.transform.forward * 30 , ForceMode.Impulse);
    }
    private void Update()
    {
        transform.LookAt(ball.transform);
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Pusher();
            timer = Random.Range(0.5f, 1.5f);
        }
    }
}
