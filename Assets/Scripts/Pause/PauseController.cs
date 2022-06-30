using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject _panelPause;
    private AudioSource _audio;
    IEnumerator BackToMainMenu()
    {
        _audio.Play();
        yield return new WaitForSecondsRealtime(0.2f);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void ClickPause()
    {
        _audio.Play();
        if (Time.timeScale != 0)
        {
            
            _panelPause.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            _panelPause.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void ClickMainMenu()
    {
        StartCoroutine(BackToMainMenu());
    }
}
