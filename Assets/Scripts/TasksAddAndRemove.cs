using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksAddAndRemove : MonoBehaviour
{
    public static Action<string> onNewTaskAdded;
    public static Action<string> onNewTaskRemoved;
}
