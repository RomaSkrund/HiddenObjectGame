using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOnItem : MonoBehaviour
{
    [SerializeField] private GameObject[] _hiddenItems;
    [SerializeField] private Text _firstListOfItemsText;
    [SerializeField] private Text _secondListOfItemsText;
    [SerializeField] private Text _thirdListOfItemsText;

    public static Action onTextEmptyBecomed;

    private List<GameObject> _firstActualList = new List<GameObject>();
    private List<GameObject> _secondActualList = new List<GameObject>();
    private List<GameObject> _thirdActualList = new List<GameObject>();
    private int _itemsCounter = 0;
    private int _lengthOfItemList = 3;

    private void Start()
    {
        AddInActualList();
        UpdateListText();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            contactWithItem();
        }
    }

    private void contactWithItem()
    {
        var rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

        if (rayHit.collider != null && rayHit.collider.gameObject.CompareTag("item"))
        {
            if (_firstActualList.Contains(rayHit.collider.gameObject))
            {
                Destroy(rayHit.collider.gameObject);
                _firstActualList.Remove(rayHit.collider.gameObject);
            }
            else if (_secondActualList.Contains(rayHit.collider.gameObject))
            {
                Destroy(rayHit.collider.gameObject);
                _secondActualList.Remove(rayHit.collider.gameObject);
            }
            else if (_thirdActualList.Contains(rayHit.collider.gameObject))
            {
                Destroy(rayHit.collider.gameObject);
                _thirdActualList.Remove(rayHit.collider.gameObject);
            }
            AddInActualList();
            UpdateListText();
            IsAllTextFieldsIsEmpty();
        }
    }

    private void AddInActualList()
    {
        if (_itemsCounter == _hiddenItems.Length) return;
        if (_firstActualList.Count < _lengthOfItemList)
        {
            while (true)
            {
                if (_firstActualList.Count == _lengthOfItemList) break;
                if (_itemsCounter == _hiddenItems.Length) break;
                _firstActualList.Add(_hiddenItems[_itemsCounter]);
                _itemsCounter++;
            }
        }
        if(_firstActualList.Count == _lengthOfItemList && _secondActualList.Count < _lengthOfItemList)
        {
            while (true)
            {
                if (_secondActualList.Count == _lengthOfItemList) break;
                if (_itemsCounter == _hiddenItems.Length) break;
                _secondActualList.Add(_hiddenItems[_itemsCounter]);
                _itemsCounter++;
            }
        }
        if (_secondActualList.Count == _lengthOfItemList && _thirdActualList.Count < _lengthOfItemList)
        {
            while (true)
            {
                if (_thirdActualList.Count == _lengthOfItemList) break;
                if (_itemsCounter == _hiddenItems.Length) break;
                _thirdActualList.Add(_hiddenItems[_itemsCounter]);
                _itemsCounter++;
            }
        }
    }

    private void UpdateListText()
    {
        _firstListOfItemsText.text = "";
        _secondListOfItemsText.text = "";
        _thirdListOfItemsText.text = "";
        for (int i = 0; i < _firstActualList.Count; i++)
        {
            _firstListOfItemsText.text += _firstActualList[i].name + "\n";
        }
        for (int i = 0; i < _secondActualList.Count; i++)
        {
            _secondListOfItemsText.text += _secondActualList[i].name + "\n";
        }
        for (int i = 0; i < _thirdActualList.Count; i++)
        {
            _thirdListOfItemsText.text += _thirdActualList[i].name + "\n";
        }
    }

    private void IsAllTextFieldsIsEmpty()
    {
        if(_firstListOfItemsText.text == "" &&
        _secondListOfItemsText.text == "" &&
        _thirdListOfItemsText.text == "")
        {
            onTextEmptyBecomed?.Invoke();
        }
    }
}
