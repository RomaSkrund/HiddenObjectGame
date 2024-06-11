using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSecondLocation : MonoBehaviour
{
    public static Action onThornsDestroyed;

    private void OnEnable()
    {
        onThornsDestroyed += ThornIsDestroyed;
    }

    private void OnDisable()
    {
        onThornsDestroyed -= ThornIsDestroyed;
    }

    private void ThornIsDestroyed()
    {
        MapButtonActivated.onNextLocationActivated?.Invoke(3);
        TasksAddAndRemove.onNewTaskRemoved?.Invoke("Сварить зелье против зарослей");
    }
}
