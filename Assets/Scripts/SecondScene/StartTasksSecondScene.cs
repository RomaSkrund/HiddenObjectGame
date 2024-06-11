using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTasksSecondScene : MonoBehaviour
{
    private void Start()
    {
        TasksAddAndRemove.onNewTaskAdded?.Invoke("Сварить зелье против зарослей");
    }
}
