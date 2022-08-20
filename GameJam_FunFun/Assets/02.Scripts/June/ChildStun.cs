using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildStun : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            for(int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).GetComponent<Enemy>().stunCor();
            }
        }
    }
}
