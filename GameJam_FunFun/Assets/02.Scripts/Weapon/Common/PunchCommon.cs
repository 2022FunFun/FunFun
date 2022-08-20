using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PunchCommon : MonoBehaviour
{
    public GameObject effect;

    void OnEnable()
    {
        transform.position = new Vector3(0, -25, 0);

        transform.DOMoveY(1.7f, 0.9f).OnComplete(() => { GameObject gameObject = 
            Instantiate(effect, this.transform.position, Quaternion.identity);
            // 기절함수
            Destroy(gameObject, 0.6f); End(); });
    }

    public void End()
    {
        DOTween.Kill(this.gameObject);
        PoolManager.Instance.Push(this.gameObject);
    }
}
