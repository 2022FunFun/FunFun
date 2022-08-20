using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    private bool mStun = false;
    private bool chainmStun = false;
    private void OnEnable()
    {
        StartCoroutine("Move");
    }


    public void stun()
    {
        mStun = true;
    }
    public void chainStun()
    {
        chainmStun = true;
    }
    IEnumerator Move()
    {
        while(true)
        {
            transform.Translate(Vector3.down*speed*Time.deltaTime);
            yield return null;
            if(mStun)
            {
                mStun = false;
                yield return new WaitForSeconds(1.5f);
            }
            if(chainmStun)
            {
                chainmStun = false;
                yield return new WaitForSeconds(3f);
            }
        }
    }


}
