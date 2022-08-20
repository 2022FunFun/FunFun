using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WaldoCommon : MonoBehaviour
{
    private void Awake()
    {
        
    }
    void OnEnable()
    {
        transform.rotation = Quaternion.Euler(0, 0, -60);
        Invoke("useWaldo",0.1f);
    }

    void useWaldo()
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
