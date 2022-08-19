using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] Button optionButton;
    [SerializeField] Button exitButton;
    [SerializeField] GameObject optionMenu;
    [SerializeField] GameObject exitMenu;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource effectSource;
    public void OnOptionMenu()
    {
        optionMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void ExitOptionMenu()
    {
        optionMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
    }
    public void SetEffectVolume(float volume)
    {
        effectSource.volume = volume;
    }
    public void OnSfx()
    {
        effectSource.Play();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Play");
    }
    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Stage01()
    {
        SceneManager.LoadScene("Stage01");
    }
    public void Stage02()
    {
        SceneManager.LoadScene("Stage02");
    }
}
