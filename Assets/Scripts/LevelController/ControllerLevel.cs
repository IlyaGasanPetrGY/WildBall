using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerLevel : MonoBehaviour
{

    IEnumerator KillAnimtion(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            yield return new WaitForSeconds(1f);
            ReloaderScene(other);
            Debug.Log("Reload");
        }
    }
    public static void ReloaderScene(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(KillAnimtion(other));
    }
}
