using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingPage : MonoBehaviour
{

    public void LoadScene1()
    {
        SceneManager.LoadScene("SettingPage1");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("SettingPage2");
    }

}
