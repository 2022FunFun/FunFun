using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDamage : MonoBehaviour
{
    PlayerHp pH;
    private void Awake()
    {
        pH = GameObject.Find("Player").GetComponent<PlayerHp>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            pH.OnDamage(() => { });
            PoolManager.Instance.Push(other.gameObject);
        }
    }
}
