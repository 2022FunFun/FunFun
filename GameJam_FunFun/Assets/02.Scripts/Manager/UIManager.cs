using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] Button optionButton;
    [SerializeField] Button exitButton;
    [SerializeField] GameObject optionMenu;
     Sequence sequence;
    [SerializeField] float textDuration;
    [SerializeField] float iconScaleDuration;
    Vector3 bigScale = new Vector3(1f, 1f, 1f);
    Vector3 smallScale = new Vector3(0f, 0f, 0f);
    [SerializeField] GameObject exitMenu;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource effectSource;
    bool isClearTutorial = false;
    bool isClearStage1 = false; 
    public void OnOptionMenu()
    {
        DOTween.Sequence().Append(optionMenu.transform.DOScale(bigScale, iconScaleDuration).SetEase(Ease.OutExpo));
        optionMenu.SetActive(true);
    }
    public void ExitOptionMenu()
    {
        DOTween.Sequence().Append(optionMenu.transform.DOScale(smallScale, iconScaleDuration).SetEase(Ease.OutElastic));
        optionMenu.SetActive(false);
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
        SceneManager.LoadScene("StageSelect");
    }
    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
        isClearTutorial = true;
    }
    public void Stage01()
    {
        if(isClearTutorial)
        SceneManager.LoadScene("Stage01");
        isClearStage1 = true;
    }
    public void Stage02()
    {
        SceneManager.LoadScene("Stage02");
    }
}
