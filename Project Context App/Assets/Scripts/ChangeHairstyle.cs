using UnityEngine;
using UnityEngine.UI;

public class ChangeHairstyle : MonoBehaviour
{
    [SerializeField] Image CharacterHair;
    public Sprite hair1;
    public Sprite hair2;
    public GameObject ColorButtons1;
    public GameObject ColorButtons2;
    public Image HairColorOne;
    public Image HairColorTwo;

    public void Button1()
    {
        CharacterHair.sprite = hair1;

        ColorButtons1.SetActive(true);
        ColorButtons2.SetActive(false);

        HairColorOne.enabled = true;
        HairColorTwo.enabled = false;
    }

    public void Button2()
    {
        CharacterHair.sprite = hair2;

        ColorButtons2.SetActive(true);
        ColorButtons1.SetActive(false);

        HairColorOne.enabled = false;
        HairColorTwo.enabled = true;
    }

}
