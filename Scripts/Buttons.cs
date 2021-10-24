using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    
    public void Game()
    {
        SceneManager.LoadScene("Testing Grounds");
    }
     public void Quit()
    {
        Application.Quit();
    }
        public void Restart()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene("Testing Grounds");
        
    }
       public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void INST()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("WTD");
    }
}
