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
        yield return new WaitForSeconds(5f);
        End();
    }

    public void End()
    {
        //StopAllCoroutines();
        Destroy(this);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            if (transform.parent.name != "YedoDefault")  
            {
                if (count == 1)
                {
                    Destroy(this.gameObject);
                }
                else
                {
                    count--;
                }

            }
            Destroy(this);
        }
    }
}
