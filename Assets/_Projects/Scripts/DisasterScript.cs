using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusText; // Reference to the status text GameObject
    public GameObject foxSprite; // Reference to the fox sprite GameObject
    public float berryCheck;
    public int disasterChance; // Chance of a disaster occurring
    public bool disasterActive = false; // Flag to check if a disaster is active
    public int berryLoss; // Amount of berries lost during a disaster
    public float gracePeriod = 10f; // Grace period in seconds for after loading a game
    private float graceTimer = 0f; // Timer to track time since loading a game

    void Start()
    {
        graceTimer = 0f; // Initializes the grace timer
    }

    // Update is called once per frame
    void Update()
    {
        // Increments the grace timer until it reaches the grace period
        if (graceTimer < gracePeriod)
        {
            graceTimer += Time.deltaTime; // Increases the timer by the time since last frame
            return; // Exits the update method if within the grace period
        }

        berryCheck = GlobalBerries.totalBerries / 10;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true; // Sets the disaster as active
        disasterChance = Random.Range(1,1); // Generates a random chance for the disaster
        if (berryCheck >= disasterChance)
        {
            berryLoss = Mathf.RoundToInt(GlobalBerries.totalBerries * 0.25f); // Calculates the berry loss
            foxSprite.SetActive(true); // Activates the fox sprite to indicate a disaster
            foxSprite.GetComponent<Animation>().Play("FoxAnim"); // Plays the fox animation
            statusText.GetComponent<TextMeshProUGUI>().text = "Disaster! You lost " + berryLoss + " berries to foxes!";
            statusText.GetComponent<Animation>().Play("StatusAnim");
            GlobalBerries.SubtractBerries(berryLoss); // Deducts the lost berries from the total
            yield return new WaitForSeconds(3); // Waits for 3 seconds before resetting the disaster
            foxSprite.SetActive(false); // Deactivates the fox sprite
            statusText.SetActive(false);
            statusText.SetActive(true);
        }
        yield return new WaitForSeconds(10); // Waits for 10 seconds before allowing another disaster
        disasterActive = false; // Resets the disaster active flag
    }
}
