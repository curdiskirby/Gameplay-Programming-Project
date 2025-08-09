using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedBerries; // Variable to hold the number of berries to save
    public int savedBerryFarmers; // Variable to hold the number of berry farmers to save
    public int savedBerryFarmerCount; // Variable to hold the number of berry farmers count to save
    public int savedBerryFarmerValue; // Variable to hold the value of berry farmers to save
    public int savedBerryBushCount; // Variable to hold the number of berry bushes to save
    public int savedBerryBushValue; // Variable to hold the value of berry bushes to save
    public int savedBerryPerClick; // Variable to hold the number of berries per click to save

    // Start is called before the first frame update
    void Start()
    {
        if (MainMenuOptions.isLoading == true)
        {
            savedBerries = PlayerPrefs.GetInt("SavedBerries", 0); // Retrieves the saved berry count, defaulting to 0 if not found
            GlobalBerries.totalBerries = savedBerries; // Sets the global berry count to the saved value
            savedBerryFarmers = PlayerPrefs.GetInt("SavedBerryFarmers", 0); // Retrieves the saved berry farmers count, defaulting to 0 if not found
            StatsDisplayScript.berriesPerSecond = savedBerryFarmers; // Sets the global berry farmers count to the saved value
            savedBerryFarmerCount = PlayerPrefs.GetInt("SavedBerryFarmerCount", 0); // Retrieves the saved berry farmer count, defaulting to 0 if not found
            StatsDisplayScript.berryFarmerCount = savedBerryFarmerCount; // Sets the global berry farmer count to the saved value
            savedBerryFarmers = PlayerPrefs.GetInt("SavedBerryFarmerValue", 50); // Retrieves the saved berry farmer value, defaulting to 50 if not found
            GlobalBerryFarmer.berryFarmerValue = savedBerryFarmers; // Sets the global berry farmer value to the saved value
            savedBerryBushCount = PlayerPrefs.GetInt("SavedBerryBushCount", 0); // Retrieves the saved berry bush count, defaulting to 0 if not found
            StatsDisplayScript.berryBushCount = savedBerryBushCount; // Sets the global berry bush count to the saved value
            savedBerryBushValue = PlayerPrefs.GetInt("SavedBerryBushValue", 150); // Retrieves the saved berry bush value, defaulting to 150 if not found
            GlobalBerryBush.berryBushValue = savedBerryBushValue; // Sets the global berry bush value to the saved value
            savedBerryPerClick = PlayerPrefs.GetInt("SavedBerryPerClick", 0); // Retrieves the saved berries per click, defaulting to 0 if not found
            StatsDisplayScript.berriesPerClick = savedBerryPerClick; // Sets the global berries per click to the saved value

        }
    }
}
