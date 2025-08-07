using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerButton : MonoBehaviour
{
    public AudioSource berrySound; // Reference to the audio source for playing sounds
    public void OnClick()
    {
        berrySound.Play(); // Plays the sound when the button is clicked
        GlobalBerries.totalBerries++; // Increments the static totalBerries variable
    }
}
