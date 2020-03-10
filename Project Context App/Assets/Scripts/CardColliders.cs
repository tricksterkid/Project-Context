using UnityEngine;
using UnityEngine.UI;

public class CardColliders : MonoBehaviour
{
    public GameObject Box;
    public Color Standard;
    public Color Active;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cards"))
        {
            Box.GetComponent<Image>().color = Active;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Box.GetComponent<Image>().color = Standard;
    }

}
