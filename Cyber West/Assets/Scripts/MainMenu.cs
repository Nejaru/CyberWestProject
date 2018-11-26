using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Scene Manager

public class MainMenu : MonoBehaviour {

    public void LoadLevel(string newLevel)
    {
        SceneManager.LoadScene(newLevel);
    }

	public void QuitGame()
    {
        print("Quit Game");
        Application.Quit();
    }
}
