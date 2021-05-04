using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Project 1");
    }

    public void Exit()
    {
        Debug.Log("Quit Game.");
        Application.Quit();
    }
}
