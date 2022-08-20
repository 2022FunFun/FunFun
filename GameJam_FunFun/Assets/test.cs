using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject effect1;

    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.M))
        {
            int random = Random.Range(0, 2);
            if(random == 0)
            {
                GameObject effect = Instantiate(effect1, this.transform.position, Quaternion.Euler(0, 0, 0));
            }
            else
            {
                GameObject effect = Instantiate(effect1, this.transform.position, Quaternion.Euler(0, 180, 0));
            }

            //Destroy(this.gameObject);
        }
    }
  
}

