using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    private bool a = false;
    private void OnEnable()
    {
        StopAllCoroutines();
        StartCoroutine(Move());
    }

    public void stunCor()
    {
        StopAllCoroutines();
        StartCoroutine(stun());
    }

    public IEnumerator stun()
    {
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while(true)
        {
            transform.Translate(Vector3.down*speed*Time.deltaTime);
            yield return null;
        }
    }
}
