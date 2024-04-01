using UnityEngine;
using UnityEngine.UI;

public class Talk : MonoBehaviour
{
    [SerializeField] private Dialogs _dialogs;
    [SerializeField] private Text _name;
    [SerializeField] private Text _text;

    private int _index;

    private void Start()
    {
        if(_dialogs != null)
        {
            NextDialog();
        }
    }

    public void NextDialog()
    {
        if (_index == _dialogs.Get.Length) return;

        _name.text = _dialogs.Get[_index].Name;
        _text.text = _dialogs.Get[_index].Text;
        _index++;
    }

    public int NumberOfPhrase => _index;
}
