using UnityEngine;
using UnityEngine.UI;

public class ChCrHairCorrect : MonoBehaviour
{

    public Sprite[] Options;
    public Image displayImage;
    public Button Next;
    public Button Previous;
    public GameObject ColorButtons1;
    public GameObject ColorButtons2;
    public GameObject ColorButtons3;
    public GameObject ColorButtons4;
    public GameObject HairColor1;
    public GameObject HairColor2;
    public GameObject HairColor3;
    public GameObject HairColor4;
    public int i = 0;

    public void BtnNext()
    {
        if(i + 1 < Options.Length)
        {
            i++;
        }
    }

    public void BtnPrevious()
    {
        if(i - 1 > 0)
        {
            i--;
        }
    }

    void Update()
    {
        displayImage.sprite = Options[i];

        if (i == 1)
        {
            ColorButtons1.SetActive(true);
            ColorButtons2.SetActive(false);
            ColorButtons3.SetActive(false);
            ColorButtons4.SetActive(false);
            HairColor1.SetActive(true);
            HairColor2.SetActive(false);
            HairColor3.SetActive(false);
            HairColor4.SetActive(false);

        } else if (i == 2)
        {
            ColorButtons1.SetActive(false);
            ColorButtons2.SetActive(true);
            ColorButtons3.SetActive(false);
            ColorButtons4.SetActive(false);
            HairColor1.SetActive(false);
            HairColor2.SetActive(true);
            HairColor3.SetActive(false);
            HairColor4.SetActive(false);
        } else if (i == 3)
        {
            ColorButtons1.SetActive(false);
            ColorButtons2.SetActive(false);
            ColorButtons3.SetActive(true);
            ColorButtons4.SetActive(false);
            HairColor1.SetActive(false);
            HairColor2.SetActive(false);
            HairColor3.SetActive(true);
            HairColor4.SetActive(false);
        } else if (i == 4)
        {
            ColorButtons1.SetActive(false);
            ColorButtons2.SetActive(false);
            ColorButtons3.SetActive(false);
            ColorButtons4.SetActive(true);
            HairColor1.SetActive(false);
            HairColor2.SetActive(false);
            HairColor3.SetActive(false);
            HairColor4.SetActive(true);
        } else
        {
            ColorButtons1.SetActive(false);
            ColorButtons2.SetActive(false);
            ColorButtons3.SetActive(false);
            ColorButtons4.SetActive(false);
            HairColor1.SetActive(false);
            HairColor2.SetActive(false);
            HairColor3.SetActive(false);
            HairColor4.SetActive(false);
        }
    }

}
