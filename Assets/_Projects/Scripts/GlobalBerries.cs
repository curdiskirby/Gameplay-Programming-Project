using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalBerries : MonoBehaviour
{
    public static int totalBerries; // Static variable to hold the total number of berries
    public GameObject berryDisplay; // Reference to the UI element that displays the berry count
    public int internalBerries; // Internal count for this instance


    public static void SubtractBerries(int amount)
    {
        totalBerries = Mathf.Max(0, totalBerries - amount); // Subtracts the specified amount from totalBerries, ensuring it doesn't go below zero
    }

    // Update is called once per frame
    void Update()
    {
        internalBerries = totalBerries; // Updates the internal count with the static total
        berryDisplay.GetComponent<TextMeshProUGUI>().text = "Berries: " + internalBerries.ToString(); // Updates the UI text with the current berry count
    }
}
