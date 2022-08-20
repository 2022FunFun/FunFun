using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public GameObject SettingUI;

    void Awake()
    {
        SetResolution();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            SettingUI.transform.DOLocalMoveX(0, 0.5f).SetUpdate(true);
        }
    }

    public void ContinueButton()
    {
        SettingUI.transform.DOLocalMoveX(-1200, 0.5f).SetUpdate(true).OnComplete(() => { Time.timeScale = 1f; } );
    }

    public void ExitButton()
    {
        Debug.Log("ExitButton");

    }

    public void SetResolution()
    {
        int setWidth = 1080; // 화면 너비
        int setHeight = 1920; // 화면 높이

        //해상도를 설정값에 따라 변경
        //3번째 파라미터는 풀스크린 모드를 설정 > true : 풀스크린, false : 창모드
        Screen.SetResolution(setWidth, setHeight, false);
    }
}
