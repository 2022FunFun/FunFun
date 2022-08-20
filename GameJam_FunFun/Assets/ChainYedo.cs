using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainYedo : MonoBehaviour
{
    void OnEnable()
    {
        transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y - 3, 0);
    }
}
