using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMenu : MonoBehaviour
{
    private AudioSource _audio;
    private int _nomberScean;
    [SerializeField] private GameObject _levels;
    [SerializeField] private GameObject _startMenu;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    IEnumerator DelayButton()
    {
        _audio.Play();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(_nomberScean);
    }
    public void ClickButtonSelectLevel()
    {
        _audio.Play();
        _startMenu.SetActive(false);
        _levels.SetActive(true);
    }
    public void ClickButtonBack()
    {
        _audio.Play();
        _startMenu.SetActive(true);
        _levels.SetActive(false);
    }
    public void FirstLevel()
    {
        _nomberScean = 1;
        StartCoroutine(DelayButton());
    }
    public void SecondLevel()
    {
        _nomberScean = 2;
        StartCoroutine(DelayButton());
    }
    public void ThirdLevel()
    {
        _nomberScean = 3;
        StartCoroutine(DelayButton());
    }
    public void FourthLevel()
    {
        _nomberScean = 4;
        StartCoroutine(DelayButton());
    }
    public void FifthLevel()
    {
        _nomberScean = 5;
        StartCoroutine(DelayButton());
    }
    


}
