using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    [SerializeField] GameObject weapon;
    
    public void UseCard(Vector3 pos)
    {
        PoolManager.Instance.Pop(weapon,pos,Quaternion.identity);
    }
}
