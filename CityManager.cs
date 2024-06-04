using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CityManager : MonoBehaviour
{

    /// <summary>
    /// each job has probability of giving money... different buildings different jobs.
    /// </summary>

    public ArrayLibrary arrayLibrary;
    public SaveManager saveManager;
    public GameManager gameManager;

    public TextMeshProUGUI announcerText;
    public TextMeshProUGUI costText;

    public TextMeshProUGUI repText;
    public TextMeshProUGUI cashText;




    public Button[] buttons; // Array to store the buttons
    public float minActiveTime = 30f; // Minimum active time in seconds
    public float maxActiveTime = 30f; // Maximum active time in seconds
    public float minInactiveTime = 60f; // Minimum inactive time in seconds
    public float maxInactiveTime = 300f; // Maximum inactive time in seconds

    void Start()
    {
        // Start coroutine for each button
        foreach (Button button in buttons)
        {
            StartCoroutine(ActivateButton(button));
        }
    }

    IEnumerator ActivateButton(Button button)
    {
        while (true)
        {
            button.gameObject.SetActive(false);

            // Wait for a random interval before activating the button again
            yield return new WaitForSeconds(Random.Range(minInactiveTime, maxInactiveTime));

            // Activate the button
            button.gameObject.SetActive(true);

            // Wait for a random interval before deactivating the button
            yield return new WaitForSeconds(Random.Range(minActiveTime, maxActiveTime));

            // Deactivate the button
            
        }
    }


    public void attemptJob(string pass)
    {



        PlayerData playerData = saveManager.GetPlayerData();

        //    int brainpowerAmount = playerData.scrapAmount;

        //   int cost = (brainpowerAmount + 1) * 10;
        if (playerData.scrapAmount >= (20))
        {

            saveManager.GetPlayerData().scrapAmount -= 20;
            //    playerData.houseRepLevel++;

            playerData.cashAmount += 5+playerData.houseRepLevel;

            repText.text = "Reputation: " + playerData.houseRepLevel;
            cashText.text = "Cash: " + playerData.cashAmount;




            // UpdateUI(level, cost, uiIndex);
            saveManager.SavePlayerData();


            if (pass == "Office")
            {
                int arrayLength = arrayLibrary.OFFICE_textsArray.Length;
                int randomIndex = Random.Range(0, arrayLength);
                announcerText.text = arrayLibrary.OFFICE_textsArray[randomIndex];
            }

            if (pass == "Hospital")
            {
                int arrayLength = arrayLibrary.HOSPITAL_textsArray.Length;
                int randomIndex = Random.Range(0, arrayLength);
                announcerText.text = arrayLibrary.HOSPITAL_textsArray[randomIndex];
            }

            if (pass == "Restaurant")
            {
                int arrayLength = arrayLibrary.RESTAURANT_textsArray.Length;
                int randomIndex = Random.Range(0, arrayLength);
                announcerText.text = arrayLibrary.RESTAURANT_textsArray[randomIndex];
            }

            if (pass == "Farm")
            {
                int arrayLength = arrayLibrary.FARM_textsArray.Length;
                int randomIndex = Random.Range(0, arrayLength);
                announcerText.text = arrayLibrary.FARM_textsArray[randomIndex];
            }


            if (pass == "Construction")
            {
                int arrayLength = arrayLibrary.CONSTRUCTION_textsArray.Length;
                int randomIndex = Random.Range(0, arrayLength);
                announcerText.text = arrayLibrary.CONSTRUCTION_textsArray[randomIndex];
            }

            if (pass == "Teaching")
            {
                int arrayLength = arrayLibrary.TEACHING_textsArray.Length;
                int randomIndex = Random.Range(0, arrayLength);
                announcerText.text = arrayLibrary.TEACHING_textsArray[randomIndex];
            }

            if (pass == "Marketing")
            {
                int arrayLength = arrayLibrary.MARKETING_textsArray.Length;
                int randomIndex = Random.Range(0, arrayLength);
                announcerText.text = arrayLibrary.MARKETING_textsArray[randomIndex];
            }




        }
        else
        {
            gameManager.ToggleVisibility();
            Debug.Log("Not enough!");
        }
        // Start is called before the first frame update
    }
}
