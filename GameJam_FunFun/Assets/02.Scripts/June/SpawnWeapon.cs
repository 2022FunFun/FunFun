using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    [SerializeField] GameObject weapon;
    
    public void UseCard(Vector3 pos)
    {
        Debug.Log("�Ϲ�ī��");
        //PoolManager.Instance.Pop(weapon,pos,Quaternion.identity);
    }

    public void UseChainCard(Vector3 pos)
    {
        Debug.Log("ü��ī��");
        //PoolManager.Instance.Pop(weapon, pos, Quaternion.identity);
    }
}
