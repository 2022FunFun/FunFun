using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PunchCommon : MonoBehaviour
{
    public GameObject effect;
    ChildStun childStun;

    private void Awake()
    {
        childStun = GameObject.Find("EnemyParent").GetComponent<ChildStun>();
    }
    void OnEnable()
    {
        //transform.position = new Vector3(0, -25, 0);

        transform.DOMove(new Vector3(transform.position.x, -5, 0), 0).OnComplete(() =>
        {
            transform.DOMoveY(1.7f, 0.3f).OnComplete(() =>
            {
                GameObject gameObject =
Instantiate(effect, this.transform.position, Quaternion.identity);
                GetComponent<CameraShake>()?.Shake();
                if (transform.name == "ChainPunch")
                    childStun.chainStun();
                else if (transform.name == "Punch")
                    childStun.commonStun();
                Destroy(gameObject, 0.6f); End();
            });
        }); 
    }

    public void End()
    {
        DOTween.Kill(this.gameObject);
        PoolManager.Instance.Push(this.gameObject);
    }
}
