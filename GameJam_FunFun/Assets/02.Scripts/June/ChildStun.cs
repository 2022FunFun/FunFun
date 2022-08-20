using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildStun : MonoBehaviour
{
    public void commonStun()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<Enemy>().stunCor();
        }
    }

    public void chainStun()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<Enemy>().chainstunCor();
        }
    }
}
