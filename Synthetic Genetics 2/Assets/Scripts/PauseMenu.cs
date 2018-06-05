using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private bool _gameIsPaused;
    public GameObject pauseMenuUI;

	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_gameIsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        _gameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        _gameIsPaused = true;
    }

    public void OnButtonBackToMenu()
    {
        SceneManager.LoadScene("TitleScreen_Scene");
    }

    public void OnButtonQuit()
    {
        Application.Quit();
    }
}
