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
    public Color Standard;
    public GameObject NextCard;

    public Slider Category1;
    public Slider Category2;
    public Slider Category3;

    public GameObject Card;
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

        // swipe to yes

        if (currentMousePosition.x > 280 && currentMousePosition.y > 340)
        {
            Yes.GetComponent<Image>().color = YesColor;
        } else
        {
            Yes.GetComponent<Image>().color = Standard;
        }

        // swipe to no

        if (currentMousePosition.x < 200 && currentMousePosition.y > 340)
        {
            No.GetComponent<Image>().color = NoColor;
        }
        else
        {
            No.GetComponent<Image>().color = Standard;
        }
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

        // if on yes, disappear and reset color
        if (currentMousePosition.x > 280 && currentMousePosition.y > 340)
        {
            gameObject.SetActive(false);
            Yes.GetComponent<Image>().color = Standard;
            // look at tag and change corresponding slider value
            if (Card.gameObject.tag == "Category1")
            {
                Category1.value++;
            }

            if (Card.gameObject.tag == "Category2")
            {
                Category2.value++;
            }

            if (Card.gameObject.tag == "Category3")
            {
                Category3.value++;
            }

            NextCard.SetActive(true);
            Skill.SetActive(true);
        }
        // if on no, disappear and reset color
        else if (currentMousePosition.x < 200 && currentMousePosition.y > 340)
        {
            gameObject.SetActive(false);
            No.GetComponent<Image>().color = Standard;
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