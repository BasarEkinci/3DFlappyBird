using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject instructionText;

    private void Start()
    {
        instructionText.transform.DOScale(new Vector3(0.8f,0.8f,0.8f), 0.8f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutCirc);
    }
}
