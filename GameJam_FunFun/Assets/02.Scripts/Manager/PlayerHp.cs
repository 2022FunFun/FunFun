using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] public float playerHp;

    public void OnDamage(Action lambda)
    {
        playerHp--;
        lambda.Invoke();
    }
    private void Update()
    {
        switch(playerHp)
        {
            case 4:
                transform.GetChild(4).gameObject.SetActive(false);
                break;
            case 3:
                transform.GetChild(3).gameObject.SetActive(false);
                break;
            case 2:
                transform.GetChild(2).gameObject.SetActive(false);
                break;
            case 1:
                transform.GetChild(1).gameObject.SetActive(false);
                break;
        }
        if(playerHp <= 0)
        {
            Die();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            OnDamage(() => { });
        }
    }
    void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("First");
    }
}
