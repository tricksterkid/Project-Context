using UnityEngine;

public class ApplicationExit : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

}
