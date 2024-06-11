using UnityEngine;

public class CursorChange : MonoBehaviour
{
    [SerializeField] private Texture2D _defaultCursor;
    [SerializeField] private Texture2D _talkCursor;
    [SerializeField] private Texture2D _zoomCursor;
    [SerializeField] private Texture2D _interactionCursor;
    [SerializeField] private Texture2D _questionCursor;
    [SerializeField] private Texture2D _handCursor;

    private void OnEnable()
    {
        HoverZoom.onZoomHovered += MouseLoupe;
        HoverZoom.onZoomNotHovered += DefaultCursor;

        HoverGears.onGearsHovered += MouseGears;
        HoverGears.onGearsNotHovered += DefaultCursor;

        HoverHand.onHandHovered += MouseHand;
        HoverHand.onHandNotHovered += DefaultCursor;

        HoverCharacter.onCharacterHovered += MouseLips;
        HoverCharacter.onCharacterNotHovered += DefaultCursor;
    }

    private void OnDisable()
    {
        HoverZoom.onZoomHovered -= MouseLoupe;
        HoverZoom.onZoomNotHovered -= DefaultCursor;

        HoverGears.onGearsHovered -= MouseGears;
        HoverGears.onGearsNotHovered -= DefaultCursor;

        HoverHand.onHandHovered -= MouseHand;
        HoverHand.onHandNotHovered -= DefaultCursor;

        HoverCharacter.onCharacterHovered -= MouseLips;
        HoverCharacter.onCharacterNotHovered -= DefaultCursor;
    }

    private void Start()
    {
        Cursor.SetCursor(_defaultCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void MouseLips()
    {
        Cursor.SetCursor(_talkCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void MouseLoupe()
    {
        Cursor.SetCursor(_zoomCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void MouseGears()
    {
        Cursor.SetCursor(_interactionCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void MouseHand()
    {
        Cursor.SetCursor(_handCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void DefaultCursor()
    {
        Cursor.SetCursor(_defaultCursor, Vector2.zero, CursorMode.ForceSoftware);
    }
}
