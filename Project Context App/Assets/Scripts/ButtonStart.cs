using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{

    public void GoToNextScene()
    {
        SceneManager.LoadScene("Screen1");
    }

}
