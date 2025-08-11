using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBerryFarmer : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentBerries;
    public static int baseBerryFarmerValue = 50;
    public static int berryFarmerValue = baseBerryFarmerValue; // Static variable to hold the value of berry farmers
    public static bool turnOffButton = false; // Static variable to control the button state

    // Update is called once per frame
    void Update()
    {
        currentBerries = GlobalBerries.totalBerries; // Gets the current total berries from the static variable
        
        fakeText.GetComponent<TextMeshProUGUI>().text = "Buy Berry Farmer - " + berryFarmerValue + " Berries"; // Updates the fake text with the cost
        realText.GetComponent<TextMeshProUGUI>().text = "Buy Berry Farmer - " + berryFarmerValue + " Berries"; // Updates the real text with the cost

        if (currentBerries >= berryFarmerValue)
        {
            fakeButton.SetActive(false); // Hides the fake button
            realButton.SetActive(true); // Shows the real button
        }
        else
        {
            fakeButton.SetActive(true); // Hides the fake button
            realButton.SetActive(false); // Shows the real button
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false); // Hides the real button if turnOffButton is true
            fakeButton.SetActive(true); // Shows the fake button
            turnOffButton = false; // Resets the static variable to false
        }
    }
}

