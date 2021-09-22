using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
	    SceneManager.LoadScene("CharacterSelection");
	    PlayerPrefs.DeleteAll();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
	    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	    PlayerPrefs.DeleteAll();
    }

    public void LoadMenu()
    {
	    SceneManager.LoadScene("MainMenu");
	    PlayerPrefs.DeleteAll();
    }

    public void Default()
    {
	    SceneManager.LoadScene("Default");
	    PlayerPrefs.DeleteAll();
	   
    }
    public void LeaderBoard()
    {

        SceneManager.LoadScene("LeaderBoard");
    } 
    
    public void LeaderDisplay()
    {

        SceneManager.LoadScene("LeaderDisplay");
    }

}
