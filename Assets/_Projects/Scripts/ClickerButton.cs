using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerButton : MonoBehaviour
{
    public AudioSource berrySound; // Reference to the audio source for playing sounds
    public void OnClick()
    {
        berrySound.Play(); // Plays the sound when the button is clicked
        GlobalBerries.totalBerries += (StatsDisplayScript.berriesPerClick + 1); // Increases the total berries by the current berries per click plus one

    }
}
