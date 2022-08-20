using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class EnemyHp : MonoBehaviour, IDamageable
{
    [SerializeField]public float hp;
    private float startHp = 0;
    public GameObject effect;
    private void Awake()
    {
        startHp = hp;
    }
    
    private void OnEnable()
    {
        hp = startHp;
    }
    public void OnDamage(Action lambda)
    {
        hp--;
        lambda?.Invoke();
    }

    private void Update()
    {
        if(hp <= 0)
        {
            Die();//여기에 죽는 애니메이션
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Weapon"))
            OnDamage(()=>{});
    }

    void Die()
    {
        int random = Random.Range(0, 2);
        if (random == 0)
        {
            GameObject effects = Instantiate(effect, this.transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(effects, 0.3f);
        }
        else
        {
            GameObject effects = Instantiate(effect, this.transform.position, Quaternion.Euler(0, 180, 0));
            Destroy(effects, 0.3f);
        }
        PoolManager.Instance.Push(this.gameObject);
    }
}