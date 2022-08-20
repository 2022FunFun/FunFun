using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class YedoCommon : MonoBehaviour
{
    int count = 2; 
    void OnEnable()
    {
        if(this.transform.parent == null)
        {
            transform.DOLocalMoveY(-1.7f, 0);
        }
        else
        {
            transform.DOLocalMoveY(1.4f, 0);
        }
        StartCoroutine((Counting()));

    }

    public IEnumerator Counting()
    {
        yield return new WaitForSeconds(1.5f);
        End();
    }

    public void End()
    {
        //StopAllCoroutines();
        Destroy(this.gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if(collision.name == "Enemy")
                collision.gameObject.GetComponent<EnemyHp>().EMinus();
            else
                collision.gameObject.GetComponent<EnemyHp>().UFOMinus();
            Destroy(collision.gameObject);
        }
    }
}
