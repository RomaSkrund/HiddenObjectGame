using UnityEngine;

public class CursorChange : MonoBehaviour
{
    [SerializeField] private Texture2D _defaultCursor;
    [SerializeField] private Texture2D _talkCursor;
    [SerializeField] private Texture2D _zoomCursor;
    [SerializeField] private Texture2D _interactionCursor;
    [SerializeField] private Texture2D _questionCursor;


    private void Start()
    {
        Cursor.SetCursor(_defaultCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void Update()
    {
        var rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
        if (rayHit.collider != null)
        {
            PointAtObject(rayHit.collider.gameObject);
        }
        else
        {
            Cursor.SetCursor(_defaultCursor, Vector2.zero, CursorMode.ForceSoftware);
        }
    }

    private void PointAtObject(GameObject obj)
    {
        switch (obj.tag)
        {
            case "Character":
                Cursor.SetCursor(_talkCursor, Vector2.zero, CursorMode.ForceSoftware);
                break;
            case "Zoom":
                Cursor.SetCursor(_zoomCursor, Vector2.zero, CursorMode.ForceSoftware); //Not use before
                break;
            case "Interact":
                Cursor.SetCursor(_interactionCursor, Vector2.zero, CursorMode.ForceSoftware); //Not use before
                break;
            case "Quest":
                Cursor.SetCursor(_questionCursor, Vector2.zero, CursorMode.ForceSoftware); //Not use before
                break;
            default:
                Cursor.SetCursor(_defaultCursor, Vector2.zero, CursorMode.ForceSoftware);
                break;
        }
    }
}
