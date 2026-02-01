using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void RetryGame()
    {
        SceneManager.LoadScene("Level 1"); //loading levels after death
    }
    public void GoTomainmenu()
    {
        SceneManager.LoadScene("main menu");
    }
}
