using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject creditsPanel;

    // ---------- PLAY ----------
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    // ---------- OPTIONS ----------
    public void OpenOptions()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    // ---------- CREDITS ----------
    public void OpenCredits()
    {
        mainMenuPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        creditsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    // ---------- EXIT ----------
    public void QuitGame()
    {
        Application.Quit();
    }
}