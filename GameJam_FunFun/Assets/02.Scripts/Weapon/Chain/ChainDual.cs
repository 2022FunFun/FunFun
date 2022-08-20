using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChainDual : MonoBehaviour
{
    void OnEnable()
    {
        //this.transform.position = new Vector3(transform.position.x, 1f, 0);
        Invoke("PlayAnimation", 0.25f);
    }

    public void PlayAnimation()
    {
        GetComponent<CameraShake>()?.Shake();
        if (this.transform.name == "Dual_2_1")
        {
            transform.DOLocalMove(new Vector3(-0.5f, -4, 0), 1f).OnComplete(() => { End(); });
        }

        if (this.transform.name == "Dual_2_2")
        {
            transform.DOLocalMove(new Vector3(0.5f, -4, 0), 1f).OnComplete(() => { End(); });
        }
    }

    public void End()
    {
        DOTween.Kill(this.gameObject);
        PoolManager.Instance.Push(this.gameObject);
    }
}
