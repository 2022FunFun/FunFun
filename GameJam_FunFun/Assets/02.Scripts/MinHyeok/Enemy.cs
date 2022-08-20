using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    private bool stun = false;
    private bool chainstun = false;
    private void OnEnable()
    {
        StartCoroutine("Move");
    }

    public void stunCor()
    {
        stun = true;
    }

    public void chainstunCor()
    {
        chainstun = true;
    }


    IEnumerator Move()
    {
        while(true)
        {
            transform.Translate(Vector3.down*speed*Time.deltaTime);
            yield return null;
            if(chainstun)
            {
                chainstun = false;
                yield return new WaitForSeconds(3f);
            }
            if(stun)
            {
                stun = false;
                yield return new WaitForSeconds(1.5f);
            }
        }
    }

    private void OnDisable()
    {
        StopCoroutine("Move");
    }
}
