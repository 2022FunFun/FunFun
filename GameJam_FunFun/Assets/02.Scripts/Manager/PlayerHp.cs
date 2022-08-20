using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] public float playerHp;
    [SerializeField] private Slider sliderHp;

    private void Awake()
    {
        sliderHp = GetComponent<Slider>();
    }
    public void OnDamage(Action lambda)
    {
        playerHp--;
        lambda.Invoke();
    }
    private void Update()
    {
        if(playerHp <= 0)
        {
            Die();
        }
        sliderHp.value = playerHp;
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
    }
}
