using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    [SerializeField] private GameObject _platform;
    [SerializeField] private Transform _secondLevel; 
    [SerializeField] private Transform[] _levels;
    private bool _startMoving;
    private void Awake()
    {
        _levels = new Transform[2] { _secondLevel, transform}; 
    }
    
    void MovePlatform()
    {
        if (_platform.transform.position == _levels[0].position)
        {
            Destroy(gameObject.GetComponent<Lift>());
        }
        _platform.transform.position = Vector3.MoveTowards(_platform.transform.position, _levels[0].position, Time.deltaTime*2);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            _startMoving = true;
        }
    }
    private void FixedUpdate()
    {
        if (_startMoving)
        {
            MovePlatform();
        }

    }
}
