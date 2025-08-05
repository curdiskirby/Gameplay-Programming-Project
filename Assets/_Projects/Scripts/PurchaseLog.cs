using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoBerries;
    public AudioSource playSound; // Reference to the audio source for playing sounds

    public void StartAutoBerries()
    {
        playSound.Play(); // Plays the sound when the button is clicked
        AutoBerries.SetActive(true);
        GlobalBerries.totalBerries -= GlobalBerryFarmer.berryFarmerValue; // Deducts the cost from total berries
        GlobalBerryFarmer.berryFarmerValue *= 2; // Doubles the value of berryFarmerValue
        GlobalBerryFarmer.turnOffButton = true; // Sets the static variable to true to turn off the button
        GlobalBerryFarmer.berriesPerSecond += 1; // Increases the berries produced per second by 1
        GlobalBerryFarmer.berryFarmerCount += 1; // Increments the count of berry farmers
    }
}
