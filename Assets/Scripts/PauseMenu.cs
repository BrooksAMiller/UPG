using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseUI;

    public static bool paused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;

    }

    public void MainMenu()
    {
        Debug.Log("Went to main menu");
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }

    void Paused()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }



}
