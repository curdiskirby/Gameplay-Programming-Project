using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuCanvas; // Reference to the pause menu canvas
    public GameObject mainGameCanvas; // Reference to the main game canvas

    public KeyCode pauseKey = KeyCode.Escape; // Default key to toggle pause menu

    public AudioSource bgmSource; // Reference to the background music AudioSource
    public AudioClip pauseMusic; // Music to play when the game is paused
    private AudioClip originalMusic; // Original music to restore when unpausing

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            if (!pauseMenuCanvas.activeSelf)
            {
                OpenPauseMenu(); // Opens the pause menu if it is not currently active
            }
            else
            {
                ClosePauseMenu(); // Closes the pause menu if it is currently active
            }
        }
    }

    public void OpenPauseMenu()
    {
        pauseMenuCanvas.SetActive(true); // Activates the pause menu canvas
        mainGameCanvas.SetActive(false); // Deactivates the main game canvas
        Time.timeScale = 0; // Pauses the game by setting the time scale to 0

        if (bgmSource != null && pauseMusic != null)
        {
            originalMusic = bgmSource.clip; // Stores the original music clip
            bgmSource.clip = pauseMusic; // Changes to pause music
            bgmSource.Play(); // Plays the pause music
        }
    }

    public void ClosePauseMenu()
    {
        pauseMenuCanvas.SetActive(false); // Deactivates the pause menu canvas
        mainGameCanvas.SetActive(true); // Activates the main game canvas
        Time.timeScale = 1; // Resumes the game by setting the time scale back to 1

        if (bgmSource != null && originalMusic != null)
        {
            bgmSource.clip = originalMusic; // Restores the original music clip
            bgmSource.Play(); // Plays the original music
        }
    }
}
