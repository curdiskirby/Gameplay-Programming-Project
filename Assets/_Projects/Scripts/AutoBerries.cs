using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBerries : MonoBehaviour
{
    public bool CreatingBerries = false;
    public static int BerriesIncreaseRate = 1; // Number of berries created per second
    public int InternalBerriesIncreaseRate; // Number of berries created per second for this instance

    // Update is called once per frame
    void Update()
    {
        BerriesIncreaseRate = StatsDisplayScript.berriesPerSecond;
        InternalBerriesIncreaseRate = BerriesIncreaseRate;
        if (CreatingBerries == false)
        {
            CreatingBerries = true;
            StartCoroutine(CreateBerries());
        }
    }

    IEnumerator CreateBerries()
    {
        GlobalBerries.totalBerries += InternalBerriesIncreaseRate; // Increments the static totalBerries variable
        yield return new WaitForSeconds(1); // Waits for 1 second before creating more berries
        CreatingBerries = false; // Resets the bool back to false to allow for the next creation cycle
    }
}
