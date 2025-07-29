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


    // Update is called once per frame
    void Update()
    {
        internalBerries = totalBerries; // Updates the internal count with the static total
        berryDisplay.GetComponent<TextMeshProUGUI>().text = "Berries: " + internalBerries.ToString(); // Updates the UI text with the current berry count
    }
}
