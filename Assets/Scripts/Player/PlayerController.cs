using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GLOBALSTRINGVariables
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody _rb;
        private Animator _anim;
        private static GameObject _killkontroller;
        [SerializeField, Range(0.2f, 10)] private float _speed = 0.3f;
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _anim = GetComponent<Animator>();
        }
        private void GettingAxis()
        {
            float horizontal = -Input.GetAxis(GlobalSTRVars.HORIZONTAL_AXIS);
            float vertical = -Input.GetAxis(GlobalSTRVars.VERTICAL_AXIS);
            Pusher(horizontal, vertical);
        }
        private void Pusher(float horizontal,float vertical)
        {
            Vector3 pushDir = new Vector3(horizontal, 0, vertical).normalized;
            _rb.AddForce(pushDir * _speed);
        }
        private void FixedUpdate()
        {
            GettingAxis();
            _anim.SetFloat("Velocity", _rb.velocity.magnitude);
        }
    }

}