using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{

    public void GoToNextScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
