using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStateManager
{
    public static void ResetGame()
    {
               // Reset all game state variables to their initial values
        GlobalBerries.totalBerries = 0; // Reset total berries
        StatsDisplayScript.berriesPerSecond = 0; // Reset berries per second
        StatsDisplayScript.berryFarmerCount = 0; // Reset berry farmer count
        GlobalBerryFarmer.berryFarmerValue = 50; // Reset berry farmer value
        StatsDisplayScript.berryBushCount = 0; // Reset berry bush count
        GlobalBerryBush.berryBushValue = 150; // Reset berry bush value
        StatsDisplayScript.berriesPerClick = 0; // Reset berries per click
        Time.timeScale = 1; // Reset time scale to normal speed
    }
}
