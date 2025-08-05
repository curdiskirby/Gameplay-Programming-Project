using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerButton : MonoBehaviour
{
    public void OnClick()
    {
        GlobalBerries.totalBerries++; // Increments the static totalBerries variable
    }
}
