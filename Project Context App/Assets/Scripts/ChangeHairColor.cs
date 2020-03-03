using UnityEngine;
using UnityEngine.UI;

public class ChangeHairColor : MonoBehaviour
{
    [SerializeField] Image HairColor;
    public Sprite color1;
    public Sprite color2;
    public Sprite color3;
    public Sprite color4;
    public Sprite color5;

    public void Button1()
    {
        HairColor.sprite = color1;
    }

    public void Button2()
    {
        HairColor.sprite = color2;
    }

    public void Button3()
    {
        HairColor.sprite = color3;
    }

    public void Button4()
    {
        HairColor.sprite = color4;
    }

    public void Button5()
    {
        HairColor.sprite = color5;
    }

}
