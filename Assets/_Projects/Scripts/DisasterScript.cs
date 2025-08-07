using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox; // Reference to the status box GameObject
    public float berryCheck;
    public int disasterChance; // Chance of a disaster occurring
    public bool disasterActive = false; // Flag to check if a disaster is active
    public int berryLoss; // Amount of berries lost during a disaster

    // Update is called once per frame
    void Update()
    {
        berryCheck = GlobalBerries.totalBerries / 10;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true; // Sets the disaster as active
        disasterChance = Random.Range(1,20); // Generates a random chance for the disaster
        if (berryCheck >= disasterChance)
        {
            berryLoss = Mathf.RoundToInt(GlobalBerries.totalBerries * 0.25f); // Calculates the berry loss
            statusBox.GetComponent<TextMeshProUGUI>().text = "Disaster! You lost " + berryLoss + " berries to foxes!";
            GlobalBerries.totalBerries -= berryLoss; // Deducts the lost berries from the total
            yield return new WaitForSeconds(3); // Waits for 3 seconds before resetting the disaster
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(10); // Waits for 10 seconds before allowing another disaster
        disasterActive = false; // Resets the disaster active flag
    }
}
