using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class FirstManager : MonoBehaviour
{
    public Image firstImage; //처음 2초정도 띄웟다가 사라짐

    public void firstImageDirection()
    {
        firstImage.raycastTarget = true;
        firstImage.DOFade(1, 2).OnComplete(()=> { firstImage.DOFade(0, 1f); });
        firstImage.raycastTarget = false;
    }
}
