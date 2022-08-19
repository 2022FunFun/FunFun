using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    [SerializeField] GameObject commonWeapon;
    [SerializeField] GameObject chainWeapon;
    
    public void UseCard(Vector3 pos)
    {
        PoolManager.Instance.Pop(commonWeapon,pos,Quaternion.identity);
    }

    public void UseChainCard(Vector3 pos)
    {
        PoolManager.Instance.Pop(chainWeapon, pos, Quaternion.identity);
    }
}
