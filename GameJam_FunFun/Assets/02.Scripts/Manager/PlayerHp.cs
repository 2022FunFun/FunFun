using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] public float playerHp;

    public GameObject sprite;

    public void OnDamage(Action lambda)
    {
        playerHp--;
        lambda.Invoke();
    }
    private void Update()
    {
        switch(playerHp)
        {
            case 2:
                transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 1:
                transform.GetChild(1).gameObject.SetActive(false);
                break;
        }
        if(playerHp <= 0)
        {
            StartCoroutine( Die());
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            OnDamage(() => { });
        }
    }

    public IEnumerator Die()
    {
        sprite.SetActive(true);
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1;
        Destroy(gameObject);
        LoadFirstScene();
    }

    public void LoadFirstScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("First");
    }
}
