using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Menu : MonoBehaviour
{

    public static bool isGamePaused = false;
    public GameObject PauseMenuUI;
    public GameObject pauseButton;
    public GameObject SettingsUI;
    public GameObject ControlsButton;
    public bool arrowKeys = true;
    public Text myText = null;

    void Update ()
    {
        if (Input.GetKeyDown("p"))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        if (isGamePaused)
        {
            resumeGame();
        }
        else
        {
            pause();
        }
    }

    void resumeGame()
    {
        PauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void pause()
    {
        PauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void openSettings()
    {
        PauseMenuUI.SetActive(false);
        SettingsUI.SetActive(true);
    }
    
    public void closeSettings()
    {
        PauseMenuUI.SetActive(true);
        SettingsUI.SetActive(false);
    }

    public void changeKeys()
    {
        if (arrowKeys)
        {
            arrowKeys = false;
            myText.text = "WASD";
        }
        else
        {
            arrowKeys = true;
            myText.text = "Arrow Keys";
        }
    }
}
