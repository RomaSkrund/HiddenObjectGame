using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddStartTasksFirstScene : MonoBehaviour
{
    private void Start()
    {
        TasksAddAndRemove.onNewTaskAdded?.Invoke("Осмотреть поляну");
    }
}
