using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject SettingUI;

    void Awake()
    {
        
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
        Time.timeScale = 1f;
        SceneManager.LoadScene("First");

    }

    
}
