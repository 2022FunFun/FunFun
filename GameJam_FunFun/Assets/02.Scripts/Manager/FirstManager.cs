using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class FirstManager : MonoBehaviour
{
    public Image firstImage; //ó�� 2������ ��m�ٰ� �����

    public void firstImageDirection()
    {
        firstImage.raycastTarget = true;
        firstImage.DOFade(1, 2).OnComplete(()=> { firstImage.DOFade(0, 1f); });
        firstImage.raycastTarget = false;
    }
}
