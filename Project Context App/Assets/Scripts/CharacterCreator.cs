using UnityEngine;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour
{

    public Sprite[] Options;
    public Image displayImage;
    public Button Next;
    public Button Previous;
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

    }

}
