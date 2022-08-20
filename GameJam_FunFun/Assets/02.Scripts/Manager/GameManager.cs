using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        SetResolution();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
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
