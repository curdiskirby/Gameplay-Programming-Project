using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerButton : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Button clicked!");
        GlobalBerries.totalBerries++; // Increments the static totalBerries variable
    }
}
