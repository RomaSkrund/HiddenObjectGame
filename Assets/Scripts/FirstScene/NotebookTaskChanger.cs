using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookTaskChanger : MonoBehaviour
{
    [SerializeField] private Text _firstText;
    [SerializeField] private Text _secondText;
    [SerializeField] private Text _thirdText;
    [SerializeField] private Text _fourthText;
    [SerializeField] private Text _fifthText;
    [SerializeField] private Text _sixthText;

    private void AddTask(string task)
    {
        if (_firstText.text == "") _firstText.text = task;
        else if (_secondText.text == "") _secondText.text = task;
        else if (_thirdText.text == "") _thirdText.text = task;
        else if (_fourthText.text == "") _fourthText.text = task;
        else if (_fifthText.text == "") _fifthText.text = task;
        else if (_sixthText.text == "") _sixthText.text = task;
    }

    private void RemoveTask(string task)
    {
        if (_firstText.text == task) _firstText.text = "";
        else if (_secondText.text == task) _secondText.text = "";
        else if (_thirdText.text == task) _thirdText.text = "";
        else if (_fourthText.text == task) _fourthText.text = "";
        else if (_fifthText.text == task) _fifthText.text = "";
        else if (_sixthText.text == task) _sixthText.text = "";
    }

    private void OnEnable()
    {
        TasksAddAndRemove.onNewTaskAdded += AddTask;
        TasksAddAndRemove.onNewTaskRemoved += RemoveTask;
    }

    private void OnDisable()
    {
        TasksAddAndRemove.onNewTaskAdded -= AddTask;
        TasksAddAndRemove.onNewTaskRemoved -= RemoveTask;
    }
}
