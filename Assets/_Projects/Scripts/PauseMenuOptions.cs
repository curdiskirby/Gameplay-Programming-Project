using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuOptions : MonoBehaviour
{
    public static bool isLoading = false; // Flag to check if a scene is currently loading
    public static bool isSaving = false; // Flag to check if a game is currently being saved
    public SaveGame saveGameScript; // Reference to the SaveGame script to handle saving functionality
    public void SaveGame()
    {
        saveGameScript.Save(); // Calls the Save method from the SaveGame script to save the game state
    }

    public void QuitGame()
    {
        Application.Quit(); // Quits the application
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stops play mode in the Unity Editor
        #endif
    }

    public void ReturntoMenu()
    {
        SceneManager.LoadScene(0); // Loads the main menu scene
        isLoading = false; // Resets the loading flag
    }
}