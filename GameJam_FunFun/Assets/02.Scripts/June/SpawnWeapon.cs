using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    [SerializeField] GameObject commonWeapon;
    [SerializeField] GameObject chainWeapon;
    
    public void UseCard(Vector3 pos)
    {
        Debug.Log("일반스킬");
        Debug.Log(pos);
        PoolManager.Instance.Pop(commonWeapon,pos, commonWeapon.transform.rotation);
        //temp.transform.SetPositionAndRotation(pos, commonWeapon.transform.rotation);
    }

    public void UseChainCard(Vector3 pos)
    {
        Debug.Log("체인스킬");

        PoolManager.Instance.Pop(chainWeapon, pos, commonWeapon.transform.rotation);
    }
}
