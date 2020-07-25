using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ForceFieldExample : MonoBehaviour
{
    void Start() {
        transform.DOPunchScale(new Vector3(0.2f, 0.2f, 0.2f),7,1).SetLoops(-1);    
    }
}
