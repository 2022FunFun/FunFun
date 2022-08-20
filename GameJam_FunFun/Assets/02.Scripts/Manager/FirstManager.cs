using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UnityEngine.SceneManagement;

public class FirstManager : MonoBehaviour
{
    public Image firstImage; //ó�� 2������ ��m�ٰ� �����

    int count = 1;
    bool isSetting;

    public GameObject Setting;

    public Button LeftButton;
    public Button RightButton;


    public GameObject leftbutton;
    public GameObject rightbutton;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    void Awake()
    {
        //SetResolution();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isSetting == true)
        {
            Setting.transform.DOLocalMoveX(-1200, 0.5f).OnComplete(() => {
                Button1.SetActive(true);
                Button2.SetActive(true);
                Button3.SetActive(true);
                leftbutton.SetActive(true);
                rightbutton.SetActive(true);
                isSetting = false; });
            
        }
    }

    public void RightMoving()
    {
        if(count == 3) { return; }
        LeftButton.interactable = false;
        RightButton.interactable = false;
        count++;
        Button1.transform.DOLocalMoveX(Button1.transform.localPosition.x - 500, 0.75f);
        Button2.transform.DOLocalMoveX(Button2.transform.localPosition.x - 500, 0.75f);
        Button3.transform.DOLocalMoveX(Button3.transform.localPosition.x - 500, 0.75f).OnComplete(()=> {
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
        Button1.transform.DOLocalMoveX(Button1.transform.localPosition.x + 500, 0.75f);
        Button2.transform.DOLocalMoveX(Button2.transform.localPosition.x + 500, 0.75f);
        Button3.transform.DOLocalMoveX(Button3.transform.localPosition.x + 500, 0.75f).OnComplete(() => {
            LeftButton.interactable = true;
            RightButton.interactable = true;
        });
    }

    public void SettingButton()
    {
        isSetting = true;
        Setting.transform.DOLocalMoveX(0, 0.5f);
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
        leftbutton.SetActive(false);
        rightbutton.SetActive(false);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //play��带 false��.
#elif UNITY_WEBPLAYER
        Application.OpenURL("http://google.com"); //���������� ��ȯ
#else
        Application.Quit(); //���ø����̼� ����
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

    public void SetResolution()
    {
        int setWidth = 540  ; // ȭ�� �ʺ�
        int setHeight = 960; // ȭ�� ����

        //�ػ󵵸� �������� ���� ����
        //3��° �Ķ���ʹ� Ǯ��ũ�� ��带 ���� > true : Ǯ��ũ��, false : â���
        Screen.SetResolution(setWidth, setHeight, false);
    }
}
