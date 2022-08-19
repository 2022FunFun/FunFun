using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WaldoCommon : MonoBehaviour
{
    void OnEnable()
    {
        transform.rotation = Quaternion.Euler(0, 0, -60);
        transform.DORotateQuaternion(Quaternion.Euler(0, 0, 60), 1f).OnComplete(() => { End(); });
        
    }

    public void End()
    {
        DOTween.Kill(this.gameObject);
        PoolManager.Instance.Push(this.gameObject);
    }
}
