using UnityEngine;

public class FirstSceneFirstDialogEvents : MonoBehaviour
{
    [SerializeField] private Talk _talk;
    [SerializeField] private GameObject _characterSprite;
    [SerializeField] private GameObject _swordSprite;

    private void Update()
    {
        if(_talk.NumberOfPhrase == 2)
            _characterSprite.SetActive(true);

        if(_talk.NumberOfPhrase == 3)
            _swordSprite.SetActive(true);

        if (_talk.NumberOfPhrase == 5)
            _swordSprite.SetActive(false);

    }
}
