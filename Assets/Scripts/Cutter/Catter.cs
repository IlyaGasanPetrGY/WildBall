
using UnityEngine;

public class Catter : MonoBehaviour
{
    [SerializeField] private GameObject _cutter;
    private void OnTriggerEnter(Collider other)
    {
        _cutter.SetActive(true);
    }
}
