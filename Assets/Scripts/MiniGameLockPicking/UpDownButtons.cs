using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpDownButtons : MonoBehaviour
{
    public static Action onFirstKeyUpPushed;
    public static Action onSecondKeyUpPushed;
    public static Action onThirdKeyUpPushed;
    public static Action onFourthKeyUpPushed;
    public static Action onFirstKeyDownPushed;
    public static Action onSecondKeyDownPushed;
    public static Action onThirdKeyDownPushed;
    public static Action onFourthKeyDownPushed;
    
    public void FirstKeyUp()
    {
        onFirstKeyUpPushed?.Invoke();
    }

    public void SecondKeyUp() 
    {
        onSecondKeyUpPushed?.Invoke();
    }

    public void ThirdKeyUp()
    {
        onThirdKeyUpPushed?.Invoke();
    }

    public void FourthKeyUp()
    {
        onFourthKeyUpPushed?.Invoke();
    }

    public void FirstKeyDown()
    {
        onFirstKeyDownPushed?.Invoke();
    }

    public void SecondKeyDown()
    {
        onSecondKeyDownPushed?.Invoke();
    }

    public void ThirdKeyDown()
    {
        onThirdKeyDownPushed?.Invoke();
    }

    public void FourthKeyDown()
    {
        onFourthKeyDownPushed?.Invoke();
    }
}
