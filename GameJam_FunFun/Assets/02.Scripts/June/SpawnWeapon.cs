using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    [SerializeField] GameObject weapon;
    
    public void UseCard(Vector3 pos)
    {
        Debug.Log("일반카드");
        //PoolManager.Instance.Pop(weapon,pos,Quaternion.identity);
    }

    public void UseChainCard(Vector3 pos)
    {
        Debug.Log("체인카드");
        //PoolManager.Instance.Pop(weapon, pos, Quaternion.identity);
    }
}
