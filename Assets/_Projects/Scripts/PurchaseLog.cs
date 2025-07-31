using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoBerries;

    public void StartAutoBerries()
    {
        AutoBerries.SetActive(true);
        GlobalBerries.totalBerries -= GlobalBerryFarmer.berryFarmerValue; // Deducts the cost from total berries
        GlobalBerryFarmer.berryFarmerValue *= 2; // Doubles the value of berryFarmerValue
        GlobalBerryFarmer.turnOffButton = true; // Sets the static variable to true to turn off the button
    }
}
