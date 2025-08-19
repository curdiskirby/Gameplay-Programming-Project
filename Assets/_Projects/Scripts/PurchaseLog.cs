using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public AudioSource playSound; // Reference to the audio source for playing sounds

    public void StartAutoBerries()
    {
        playSound.Play(); // Plays the sound when the button is clicked
        GlobalBerries.SubtractBerries(GlobalBerryFarmer.berryFarmerValue); // Deducts the cost from total berries
        StatsDisplayScript.berryFarmerCount += 1; // Increments the count of berry farmers
        GlobalBerryFarmer.berryFarmerValue = (int)(GlobalBerryFarmer.baseBerryFarmerValue * Mathf.Pow(1.13f, StatsDisplayScript.berryFarmerCount) * (1 + StatsDisplayScript.berryFarmerCount * 0.1f) + (StatsDisplayScript.berryFarmerCount * 25)); // Updates the value of berryFarmerValue based on the count of berry farmers
        GlobalBerryFarmer.turnOffButton = true; // Sets the static variable to true to turn off the button
        StatsDisplayScript.berriesPerSecond += 1; // Increases the berries produced per second by 1
    }

    public void BerryBushUpgrade()
    {
        playSound.Play(); // Plays the sound when the button is clicked
        GlobalBerries.SubtractBerries(GlobalBerryBush.berryBushValue); // Deducts the cost from total berries
        StatsDisplayScript.berryBushCount += 1; // Increments the count of berry bushes
        GlobalBerryBush.berryBushValue = (int)(GlobalBerryBush.baseBerryBushValue * Mathf.Pow(1.20f, StatsDisplayScript.berryBushCount) * (1 + StatsDisplayScript.berryBushCount * 0.25f) + (StatsDisplayScript.berryBushCount * 25)); // Updates the value of berryBushValue based on the count of berry bushes
        GlobalBerryBush.turnOffButton = true; // Sets the static variable to true to turn off the button
        StatsDisplayScript.berriesPerClick += 1; // Increases the berries produced per click by 1
    }
}
