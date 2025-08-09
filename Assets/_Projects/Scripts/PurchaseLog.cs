using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public AudioSource playSound; // Reference to the audio source for playing sounds

    public void StartAutoBerries()
    {
        playSound.Play(); // Plays the sound when the button is clicked
        GlobalBerries.totalBerries -= GlobalBerryFarmer.berryFarmerValue; // Deducts the cost from total berries
        GlobalBerryFarmer.berryFarmerValue *= 2; // Doubles the value of berryFarmerValue
        GlobalBerryFarmer.turnOffButton = true; // Sets the static variable to true to turn off the button
        StatsDisplayScript.berriesPerSecond += 1; // Increases the berries produced per second by 1
        StatsDisplayScript.berryFarmerCount += 1; // Increments the count of berry farmers
    }

    public void BerryBushUpgrade()
    {
        playSound.Play(); // Plays the sound when the button is clicked
        GlobalBerries.totalBerries -= GlobalBerryBush.berryBushValue; // Deducts the cost from total berries
        GlobalBerryBush.berryBushValue *= 2; // Doubles the value of berryBushValue
        GlobalBerryBush.turnOffButton = true; // Sets the static variable to true to turn off the button
        StatsDisplayScript.berriesPerClick += 1; // Increases the berries produced per click by 1
        StatsDisplayScript.berryBushCount += 1; // Increments the count of berry bushes
    }
}
