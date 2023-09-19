using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System;

public class ButtonsManager : MonoBehaviour
{
    public Image imageToScale;
    private bool isPressed = false;
    [Range(0, 1)]
    public float targetScale;
    [Range(0, 1)]
    public float duration;
    private float zeroVal = 0;
    public Vector3 rotate;
    private Vector3 inverse;

    /*public void Zoom()
    {
        float zoomVal = 0;
        targetScale = isPressed ? 25.0f : zoomVal;
        imageToScale.transform.DOScale(targetScale, 0.25f);
        isPressed = !isPressed;
    }*/

    //scale

    public void Scale()
    {
        imageToScale.DOFade(0, duration);
        targetScale = isPressed ? 2.0f : zeroVal;
        imageToScale.transform.DOScale(targetScale, duration).SetEase(Ease.Linear);
        isPressed = !isPressed;
        if (!isPressed)
        {
            imageToScale.DOFade(1, duration);
        }
    }

    //zoom
    public void Zoom()
    {
        //(condition) = someBooleanExpression ? true path : false path
        targetScale = isPressed ? 2.0f : zeroVal;
        imageToScale.transform.DOScale(targetScale, duration).SetEase(Ease.Linear);
        isPressed = !isPressed;
    }

    //fade
    public void Fade()
    {
        targetScale = isPressed ? 2.0f : zeroVal;
        imageToScale.DOFade(0, duration);
        isPressed = !isPressed;
        if (!isPressed)
        {
            imageToScale.DOFade(1, duration);
        }
    }

    //flip
    public void Flip()
    {
        
        targetScale = isPressed ? 2.0f : zeroVal;
        imageToScale.transform.DORotate(rotate, duration);

        isPressed = !isPressed;

        if(!isPressed)
        {
            imageToScale.transform.DORotate(inverse, duration);
        }
    }
    //drop
    public void Drop()
    {

    }
    //fly
    public void Fly()
    {

    }
}
