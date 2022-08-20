using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WaldoCommon : MonoBehaviour
{
    void OnEnable()
    {
        Invoke("PlayAnimation", 0.15f);
    }

    public void PlayAnimation()
    {
        transform.rotation = Quaternion.Euler(0, 0, -60);
        GetComponent<CameraShake>()?.Shake();
        transform.DORotateQuaternion(Quaternion.Euler(0, 0, 60), 1f).OnComplete(() => { End(); });
    }

    public void End()
    {
        transform.rotation = Quaternion.Euler(0, 0, -60);
        DOTween.Kill(this.gameObject);
        PoolManager.Instance.Push(this.gameObject);
    }
}
