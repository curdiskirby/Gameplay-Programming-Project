using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerButton : MonoBehaviour
{
    public AudioSource berrySound; // Reference to the audio source for playing sounds
    public GameObject clickerButton; // Reference to the button GameObject

    void Start()
    {
        clickerButton.GetComponent<Button>().image.alphaHitTestMinimumThreshold = 0.01f; // Sets the alpha hit test minimum threshold for the button image
    }
    public void OnClick()
    {
        berrySound.Play(); // Plays the sound when the button is clicked
        GlobalBerries.totalBerries += (StatsDisplayScript.berriesPerClick + 1); // Increases the total berries by the current berries per click plus one

    }
}
