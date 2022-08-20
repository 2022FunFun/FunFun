using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;

public class FirstManager : MonoBehaviour
{
    public Image firstImage; //처음 2초정도 띄웟다가 사라짐

    int count = 1;
    bool isSetting;

    public GameObject Setting;

    public Button LeftButton;
    public Button RightButton;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isSetting == true)
        {
            Setting.transform.DOLocalMoveX(-6, 0.5f).OnComplete(() => { isSetting = false; });
            
        }
    }

    public void RightMoving()
    {
        if(count == 3) { return; }
        LeftButton.interactable = false;
        RightButton.interactable = false;
        count++;
        Button1.transform.DOLocalMoveX(Button1.transform.localPosition.x - 900, 0.75f);
        Button2.transform.DOLocalMoveX(Button2.transform.localPosition.x - 900, 0.75f);
        Button3.transform.DOLocalMoveX(Button3.transform.localPosition.x - 900, 0.75f).OnComplete(()=> {
            LeftButton.interactable = true;
            RightButton.interactable = true;
        });
    }

    public void LeftMoving()
    {
        if (count == 1) { return; }
        LeftButton.interactable = false;
        RightButton.interactable = false;
        count--;
        Button1.transform.DOLocalMoveX(Button1.transform.localPosition.x + 900, 0.75f);
        Button2.transform.DOLocalMoveX(Button2.transform.localPosition.x + 900, 0.75f);
        Button3.transform.DOLocalMoveX(Button3.transform.localPosition.x + 900, 0.75f).OnComplete(() => {
            LeftButton.interactable = true;
            RightButton.interactable = true;
        });
    }

    public void SettingButton()
    {
        isSetting = true;
        Setting.transform.DOLocalMoveX(0, 0.5f);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //play모드를 false로.
#elif UNITY_WEBPLAYER
        Application.OpenURL("http://google.com"); //구글웹으로 전환
#else
        Application.Quit(); //어플리케이션 종료
#endif
    }

    public void loadStage1()
    {
        SceneManager.LoadScene("Stage01");
    }

    public void loadStage2()
    {
        SceneManager.LoadScene("Stage02");
    }

    public void loadStage3()
    {
        SceneManager.LoadScene("Stage03");
    }

    //public void firstImageDirection()
    //{
    //    firstImage.raycastTarget = true;
    //    firstImage.DOFade(1, 2).OnComplete(()=> { firstImage.DOFade(0, 1f); });
    //    firstImage.raycastTarget = false;
    //}
}
