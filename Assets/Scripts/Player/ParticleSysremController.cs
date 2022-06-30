using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSysremController : MonoBehaviour
{
    [SerializeField] private Transform _player;
    void Update()
    {
        transform.position = _player.position;
    }
}
