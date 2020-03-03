using UnityEngine;
using UnityEngine.UI;

public class ChangeClothes : MonoBehaviour
{
    [SerializeField] Image CharacterClothes;
    public Sprite clothes1;
    public Sprite clothes2;
    public Sprite clothes3;

    public void Button1()
    {
        CharacterClothes.sprite = clothes1;
    }

    public void Button2()
    {
        CharacterClothes.sprite = clothes2;
    }

    public void Button3()
    {
        CharacterClothes.sprite = clothes3;
    }

}
