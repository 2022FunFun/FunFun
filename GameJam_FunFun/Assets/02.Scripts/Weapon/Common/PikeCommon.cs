using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PikeCommon : MonoBehaviour
{
    public AudioSource audioSource;

    void OnEnable()
    {
        transform.DOMoveY(10f, 1.5f).OnComplete(() => { End(); });
    }

    public void End()
    {
        DOTween.Kill(this.gameObject);
        PoolManager.Instance.Push(this.gameObject);
    }
}
