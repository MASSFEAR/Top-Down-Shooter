using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public void OnButtonStart()
    {
        SceneManager.LoadScene("Tutorial_Level");
    }

    public void OnButtonHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay_Scene");
    }

    public void OnButtonQuit()
    {
        Application.Quit();
    }

    public void OnButtonBack()
    {
        SceneManager.LoadScene("TitleScreen_Scene");
    }
}
