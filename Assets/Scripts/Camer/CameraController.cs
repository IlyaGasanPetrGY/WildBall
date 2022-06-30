using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform _playerTrans;
    public static Vector3 distCamera;
    public static Transform _mainCamera;
    private void Awake()
    {
        _playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        _mainCamera = transform;
        distCamera = _playerTrans.position - transform.position;
        Debug.Log(distCamera);
    }
    private void Update()
    {
        transform.position = _playerTrans.position - distCamera;
    }
}
