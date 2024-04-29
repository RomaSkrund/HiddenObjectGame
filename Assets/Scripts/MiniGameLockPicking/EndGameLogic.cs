using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMagicDoorGameLogic : MonoBehaviour
{
    [SerializeField] private MasterKeyChanger _firstMasterMasterKey;
    [SerializeField] private MasterKeyChanger _secondMasterMasterKey;
    [SerializeField] private MasterKeyChanger _thirdMasterMasterKey;
    [SerializeField] private MasterKeyChanger _fourthMasterMasterKey;

    [SerializeField] private LockButtonsCreate _lockButtonsCreate;

    [SerializeField] private GameObject _masterKeyGroup;
    [SerializeField] private GameObject _lockKeyGroup;

    private void OnEnable()
    {
        ToLockButton.onToLeftButtonPushed += RightPositionChecker;
    }

    private void OnDisable()
    {
        ToLockButton.onToLeftButtonPushed -= RightPositionChecker;
    }

    private void RightPositionChecker()
    {
        if((_firstMasterMasterKey.KeyValue == _lockButtonsCreate.FirstLock) &&
           (_secondMasterMasterKey.KeyValue == _lockButtonsCreate.SecondLock) &&
           (_thirdMasterMasterKey.KeyValue == _lockButtonsCreate.ThirdLock) &&
           (_fourthMasterMasterKey.KeyValue == _lockButtonsCreate.FourthLock))
        {
            Debug.Log("Крутой чел пацан прошел игру");
        }
        else
        {
            Invoke(nameof(BackToKey), 3f);
        }
    }

    private void BackToKey()
    {
        _lockKeyGroup.SetActive(false);
        _masterKeyGroup.SetActive(true);
    }
}
