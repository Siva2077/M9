using UnityEngine;
using UnityEngine.SceneManagement;
public class GameCompleteUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ReplayLevel()
    {
        SceneManager.LoadScene("Level 1");// change if needed
    }
    public void GoTomainmenu()
    {
        SceneManager.LoadScene("main menu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
