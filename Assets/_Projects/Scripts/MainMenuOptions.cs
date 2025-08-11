using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    public static bool isLoading = false; // Flag to check if a scene is currently loading

    public void NewGame()
    {
        GameStateManager.ResetGame(); // Resets the game state
        isLoading = false; // Reset loading state
        SceneManager.LoadScene(1); // Loads the main game scene
    }

    public void LoadGame()
    {
        isLoading = true; // Sets the loading flag to true
        SceneManager.LoadScene(1); // Loads the main game scene
    }

    public void QuitGame()
    {
        Application.Quit(); // Quits the application
        Debug.Log("Game has been closed."); // Logs a message to the console
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stops play mode in the Unity Editor
        #endif
    }
}