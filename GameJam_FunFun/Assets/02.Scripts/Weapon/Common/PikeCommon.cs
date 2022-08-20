using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PikeCommon : MonoBehaviour
{
    void Awake()
    {
        transform.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 0);
        Debug.Log(transform.position);
    }
    void OnEnable()
    {
        Invoke("Sibal", 0.0000001f);

    }

    public void Sibal()
    {
        transform.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);
        //transform.position = new Vector3(0, -15, 0);
        Debug.Log("¿òÁ÷¿©");
        transform.DOMove(new Vector3(transform.position.x, -15, 0), 0).OnComplete(() => { transform.DOMoveY(10, 1.5f); });
        Invoke("End", 1.5f);
    }

    public void End()
    {
        Debug.Log("Á×¾î");
        //DOTween.Kill(this.gameObject);
        Destroy(this.gameObject);
    }
}
