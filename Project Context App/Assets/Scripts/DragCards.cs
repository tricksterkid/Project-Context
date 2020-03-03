using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragCards : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector2 lastMousePosition;
    public GameObject Yes;
    public Color YesColor;
    public GameObject No;
    public Color NoColor;
    public GameObject Unsure;
    public Color UnsureColor;
    public Color Standard;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        lastMousePosition = eventData.position;
    }

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

        if (currentMousePosition.x > 280 && currentMousePosition.y > 340)
        {
            Debug.Log("Wah");
            Yes.GetComponent<Image>().color = YesColor;
        } else
        {
            Yes.GetComponent<Image>().color = Standard;
        }

        if (currentMousePosition.x < 200 && currentMousePosition.y > 340)
        {
            Debug.Log("Woo");
            No.GetComponent<Image>().color = NoColor;
        }
        else
        {
            No.GetComponent<Image>().color = Standard;
        }

        if (currentMousePosition.y < 340)
        {
            Debug.Log("UUUUU");
            Unsure.GetComponent<Image>().color = UnsureColor;
        }
        else
        {
            Unsure.GetComponent<Image>().color = Standard;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
    }

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