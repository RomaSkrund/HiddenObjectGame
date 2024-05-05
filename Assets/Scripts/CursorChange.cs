using UnityEngine;

public class CursorChange : MonoBehaviour
{
    [SerializeField] private Texture2D _defaultCursor;
    [SerializeField] private Texture2D _talkCursor;
    [SerializeField] private Texture2D _zoomCursor;
    [SerializeField] private Texture2D _interactionCursor;
    [SerializeField] private Texture2D _questionCursor;

    private void OnEnable()
    {
        TalkToCharacter.onMouseOnCharMoved += MouseOnCharacter;
        TalkToCharacter.onMouseOutCharMoved += DefaultCursor;
    }

    private void OnDisable()
    {
        TalkToCharacter.onMouseOnCharMoved -= MouseOnCharacter;
        TalkToCharacter.onMouseOutCharMoved -= DefaultCursor;
    }

    private void Start()
    {
        Cursor.SetCursor(_defaultCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void MouseOnCharacter()
    {
        Cursor.SetCursor(_talkCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void DefaultCursor()
    {
        Cursor.SetCursor(_defaultCursor, Vector2.zero, CursorMode.ForceSoftware);
    }
}
