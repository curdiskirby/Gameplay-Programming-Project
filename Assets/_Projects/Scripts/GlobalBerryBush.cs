using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBerryBush : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentBerries;
    public static int berryBushValue = 150;
    public static bool turnOffButton = false; // Static variable to control the button state

    // Update is called once per frame
    void Update()
    {
        currentBerries = GlobalBerries.totalBerries; // Gets the current total berries from the static variable

        fakeText.GetComponent<TextMeshProUGUI>().text = "Buy Berry \nBush - " + berryBushValue + " Berries"; // Updates the fake text with the cost
        realText.GetComponent<TextMeshProUGUI>().text = "Buy Berry \nBush - " + berryBushValue + " Berries"; // Updates the real text with the cost

        if (currentBerries >= berryBushValue)
        {
            fakeButton.SetActive(false); // Hides the fake button
            realButton.SetActive(true); // Shows the real button
        } 
        
        if (turnOffButton == true)
        {
            realButton.SetActive(false); // Hides the real button if turnOffButton is true
            fakeButton.SetActive(true); // Shows the fake button
            turnOffButton = false; // Resets the static variable to false
        }
    }
}

