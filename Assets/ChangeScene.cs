using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject StartBut;
    public GameObject FinalMenu;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Game"))
            PlayerPrefs.SetString("Game", "start"); 
        Time.timeScale = 0f;
        if (!PlayerPrefs.GetString("Game").Equals("start"))
        {
            StartBut.SetActive(false);
            Time.timeScale = 1f;
        }
       
    }

    public void StartGame()
    {
        StartBut.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        FinalMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void QuitGame()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }

}
