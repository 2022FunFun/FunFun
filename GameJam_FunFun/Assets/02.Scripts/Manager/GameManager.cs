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
        int setWidth = 1080; // ȭ�� �ʺ�
        int setHeight = 1920; // ȭ�� ����

        //�ػ󵵸� �������� ���� ����
        //3��° �Ķ���ʹ� Ǯ��ũ�� ��带 ���� > true : Ǯ��ũ��, false : â���
        Screen.SetResolution(setWidth, setHeight, false);
    }
}
