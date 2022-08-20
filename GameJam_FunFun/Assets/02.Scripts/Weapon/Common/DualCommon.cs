using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DualCommon : MonoBehaviour
{
    void OnEnable()
    {
        //this.transform.position = new Vector3(transform.position.x, 1f, 0);
        Invoke("PlayAnimation", 0.25f);
    }

    public void PlayAnimation()
    {
        if (this.transform.name == "Dual_1_1")
        {
            transform.DOLocalMove(new Vector3(this.transform.localPosition.x - 2f, transform.transform.localPosition.y - 2f, 0), 0.7f).OnComplete(() => { End(); });
        }

        if (this.transform.name == "Dual_1_2")
        {
            transform.DOLocalMove(new Vector3(this.transform.localPosition.x + 2f, transform.transform.localPosition.y - 2f, 0), 0.7f).OnComplete(() => { End(); });
        }
    }

    public void End()
    {
        DOTween.Kill(this.gameObject);
        PoolManager.Instance.Push(this.gameObject);
    }


}
