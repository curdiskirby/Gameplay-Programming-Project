using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    public static bool isLoading = false; // Flag to check if a scene is currently loading

    public void NewGame()
    {
        SceneManager.LoadScene(1); // Loads the main game scene
    }

    public void LoadGame()
    {
        isLoading = true; // Sets the loading flag to true
        SceneManager.LoadScene(1); // Loads the main game scene
    }
}
