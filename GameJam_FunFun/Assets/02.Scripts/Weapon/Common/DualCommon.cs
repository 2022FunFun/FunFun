using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DualCommon : MonoBehaviour
{
    void OnEnable()
    {
        this.transform.position = new Vector3(transform.position.x, 2f, 0);
        Invoke("PlayAnimation", 0.5f);
    }

    public void PlayAnimation()
    {
        if (this.transform.name == "Dual_1_1")
        {
            transform.DOLocalMove(new Vector3(this.transform.position.x - 0.8f, transform.transform.position.y - 0.8f, 0), 0.4f).OnComplete(() => { End(); });
        }

        //if (this.transform.name == "Dual_1_2")
        //{
        //    transform.DOLocalMove(new Vector3(this.transform.position.x + 0.8f, transform.transform.position.y - 0.8f, 0), 0.4f).OnComplete(() => { End(); });
        //}
    }

    public void End()
    {
        DOTween.Kill(this.gameObject);
        PoolManager.Instance.Push(this.gameObject);
    }


}
