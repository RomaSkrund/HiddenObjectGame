using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSceneSecondDialogEvents : MonoBehaviour
{
    [SerializeField] private Talk _talk;
    [SerializeField] private GameObject _paperSprite;
    [SerializeField] private GameObject _dialogGroup;

    private void Update()
    {
        switch (_talk.NumberOfPhrase)
        {
            case 7:
                _paperSprite.SetActive(false);
                break;
            case 10:
                TasksAddAndRemove.onNewTaskRemoved?.Invoke("Осмотреть поляну");
                MapButtonActivated.onNextLocationActivated?.Invoke(2);
                _dialogGroup.SetActive(false);
                break;
        }
    }
}
