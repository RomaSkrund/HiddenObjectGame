using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicDoorLogic : MonoBehaviour
{
    [SerializeField] private GameObject _magicDoorGroup;
    [SerializeField] private GameObject _miniGameUIGroup;
    [SerializeField] private GameObject _hintGroup;
    [SerializeField] private GameObject _poisonGroup;

    private void OnMouseDown()
    {
        HintMessageSend.onHintSended?.Invoke("Тут так просто не пройдешь, дверь магией защищена. Но что-то на ней виднеется, нужно вещь какую-то, которая разглядеть получше позволит");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Lens")
        {
            _magicDoorGroup.SetActive(true);
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            _miniGameUIGroup.SetActive(true);
            _hintGroup.SetActive(false);
            _poisonGroup.SetActive(false);
        }
    }
}
