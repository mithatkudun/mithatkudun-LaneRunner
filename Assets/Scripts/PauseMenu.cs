using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausemenuui;
  
    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1.0f;
       
    }
   public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        GameIsPaused = false;
        pausemenuui.SetActive(false);
    }
   public void PauseGame()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        pausemenuui.SetActive(true);
    }
    public void RestartLevel()
    {
        GameIsPaused = false;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void tryagain()
    {
        GameIsPaused = false;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        GameIsPaused = false;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("mainmenu");
    }

}
