using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StatsDisplayScript : MonoBehaviour
{
    public GameObject Stats;
    public static int berryFarmerCount;
    public static int berriesPerSecond;
    public static int berryBushCount;
    public static int berriesPerClick;

    // Update is called once per frame
    void Update()
    {
        Stats.GetComponent<TextMeshProUGUI>().text = "Berry Farmers: " + berryFarmerCount + " @ " + berriesPerSecond + " Per Second" + "\n"
        + "Berry Farmers: " + berryBushCount + " @ +" + berriesPerClick + " Per Click"; // Updates the stats text with the current value
    }
}
