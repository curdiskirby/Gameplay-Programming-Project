using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveGame : MonoBehaviour
{
    public GameObject saveText; // Reference to the UI text element that displays the save status
    public void Save()
    {
        PlayerPrefs.SetInt("SavedBerries", GlobalBerries.totalBerries); // Saves the current berry count to PlayerPrefs
        PlayerPrefs.SetInt("SavedBerryFarmers", StatsDisplayScript.berriesPerSecond); // Saves the current berry farmers count to PlayerPrefs
        PlayerPrefs.SetInt("SavedBerryFarmerCount", StatsDisplayScript.berryFarmerCount); // Saves the current berry farmer count to PlayerPrefs
        PlayerPrefs.SetInt("SavedBerryFarmerValue", GlobalBerryFarmer.berryFarmerValue); // Saves the current berry farmer value to PlayerPrefs
        PlayerPrefs.SetInt("SavedBerryBushCount", StatsDisplayScript.berryBushCount); // Saves the current berry bush count to PlayerPrefs
        PlayerPrefs.SetInt("SavedBerryBushValue", GlobalBerryBush.berryBushValue); // Saves the current berry bush value to PlayerPrefs
        PlayerPrefs.SetInt("SavedBerryPerClick", StatsDisplayScript.berriesPerClick); // Saves the current berries per click to PlayerPrefs
        PlayerPrefs.Save(); // Ensures that the data is saved immediately

        saveText.GetComponent<TextMeshProUGUI>().text = "Game Saved!"; // Updates the UI text to indicate that the game has been saved
        StartCoroutine(ResetSaveText()); // Starts a coroutine to reset the save text after a delay
    }

    private IEnumerator ResetSaveText()
    {
        yield return new WaitForSeconds(1); // Waits for 2 seconds
        saveText.GetComponent<TextMeshProUGUI>().text = "Save Game"; // Resets the save text to an empty string
    }
}
