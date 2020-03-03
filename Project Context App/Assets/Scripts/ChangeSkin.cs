using UnityEngine;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour
{
    [SerializeField] Image SkinColor;
    public Sprite skin1;
    public Sprite skin2;
    public Sprite skin3;
    public Sprite skin4;
    public Sprite skin5;
    public Sprite skin6;

    public void Button1()
    {
        SkinColor.sprite = skin1;
    }

    public void Button2()
    {
        SkinColor.sprite = skin2;
    }

    public void Button3()
    {
        SkinColor.sprite = skin3;
    }

    public void Button4()
    {
        SkinColor.sprite = skin4;
    }

    public void Button5()
    {
        SkinColor.sprite = skin5;
    }

    public void Button6()
    {
        SkinColor.sprite = skin6;
    }

}
