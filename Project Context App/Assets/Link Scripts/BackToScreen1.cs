using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToScreen1 : MonoBehaviour
{

    public void GoToNextScene()
    {
        SceneManager.LoadScene("Screen1");
    }

}
