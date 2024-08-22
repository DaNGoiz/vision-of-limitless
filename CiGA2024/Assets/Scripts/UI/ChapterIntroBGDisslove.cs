using Coffee.UIEffects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ChapterIntroBGDisslove : MonoBehaviour
{
    [SerializeField]
    UIDissolve iDissolve;
    [SerializeField]
    float waitTime;
    [SerializeField]
    float animTime;

    void Start()
    {
        StartCoroutine(BGDissolve());
    }

    IEnumerator BGDissolve()
    {
        // DOTween.To(() => iDissolve.effectFactor, x => iDissolve.effectFactor = x, 0f, time);
        yield return new WaitForSeconds(waitTime);
        DOTween.To(() => iDissolve.effectFactor, x => iDissolve.effectFactor = x, 1.1f, animTime);
    }
}
