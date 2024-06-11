using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameSkip : MonoBehaviour
{
    public static Action onSkipButtonPushed;

    public void SkipMiniGame()
    {
        onSkipButtonPushed?.Invoke();
    }
}
