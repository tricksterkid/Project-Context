using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveCards : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private int ScreenSize = Screen.width / 2;
    private Vector2 lastMousePosition;
    public GameObject NextCard;
    public Slider CorrectSlider;
    public GameObject Skill;

    // start drag

    public void OnBeginDrag(PointerEventData eventData)
    {
        lastMousePosition = eventData.position;
    }

    // when dragging

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentMousePosition = eventData.position;
        Vector2 diff = currentMousePosition - lastMousePosition;
        RectTransform rect = GetComponent<RectTransform>();

        Vector3 newPosition = rect.position + new Vector3(diff.x, diff.y, transform.position.z);
        Vector3 oldPos = rect.position;
        rect.position = newPosition;

        if (!IsRectTransformInsideSreen(rect))
        {
            rect.position = oldPos;
        }
        lastMousePosition = currentMousePosition;
    }

    // end drag

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector2 currentMousePosition = eventData.position;
        Vector2 diff = currentMousePosition - lastMousePosition;
        RectTransform rect = GetComponent<RectTransform>();

        Vector3 newPosition = rect.position + new Vector3(diff.x, diff.y, transform.position.z);
        Vector3 oldPos = rect.position;
        rect.position = newPosition;

        // if on yes, disappear
        if (currentMousePosition.x > ScreenSize && currentMousePosition.y > 340)
        {
            gameObject.SetActive(false);
            NextCard.SetActive(true);
            CorrectSlider.value++;
            Skill.SetActive(true);
        }
        // if on no, disappear
        else if (currentMousePosition.x < ScreenSize && currentMousePosition.y > 340)
        {
            gameObject.SetActive(false);
            NextCard.SetActive(true);
        }
        // if not on anything, keep object alive
        else
        {
            gameObject.SetActive(true);
        }
    }

    // keep card inside screen

    private bool IsRectTransformInsideSreen(RectTransform rectTransform)
    {
        bool isInside = false;
        Vector3[] corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);
        int visibleCorners = 0;
        Rect rect = new Rect(0, 0, Screen.width, Screen.height);
        foreach (Vector3 corner in corners)
        {
            if (rect.Contains(corner))
            {
                visibleCorners++;
            }
        }
        if (visibleCorners == 4)
        {
            isInside = true;
        }
        return isInside;
    }
}