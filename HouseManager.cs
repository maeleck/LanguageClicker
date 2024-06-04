using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HouseManager : MonoBehaviour
{




    /// <summary>
    /// need to adjust the picture based on house rep and draw more
    /// need to add arrays for chatter
    /// </summary>










    // Start is called before the first frame update
    public ArrayLibrary arrayLibrary;
    public SaveManager saveManager;
    public GameManager gameManager;

    public TextMeshProUGUI announcerText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI repText;
    void Start()
    {
        PlayerData playerData = saveManager.GetPlayerData();

        int reputationAmount = playerData.houseRepLevel;


        // Ensure that the reputation amount is within the range of available images
        if (reputationAmount >= 0 && reputationAmount < reputationImages.Length)
        {
            // Set the sprite of the Image component based on the reputation amount
            containerMain.sprite = reputationImages[reputationAmount];
        }






    }

    public void houseChatterMethod()
    {
        //   announcerText.text = "Test";
        int arrayLength = arrayLibrary.HOUSE_textsArray.Length;
        int randomIndex = Random.Range(0, arrayLength);
        announcerText.text = arrayLibrary.HOUSE_textsArray[randomIndex];
    }

    public void buyHouseUpgrade()
    {

        PlayerData playerData = saveManager.GetPlayerData();

    //    int brainpowerAmount = playerData.scrapAmount;

     //   int cost = (brainpowerAmount + 1) * 10;
        if (playerData.scrapAmount >= ((playerData.houseRepLevel+1)*50) )
        {

            saveManager.GetPlayerData().scrapAmount -= ((playerData.houseRepLevel + 1) * 50);
            playerData.houseRepLevel++;
            

            repText.text = "Reputation: " + playerData.houseRepLevel;
            costText.text = "Cost: " + (playerData.houseRepLevel + 1) * 50;
            // UpdateUI(level, cost, uiIndex);

            UpdateImage();

            saveManager.SavePlayerData();
        }
        else
        {
            gameManager.ToggleVisibility();
            Debug.Log("Not enough!");
        }
    }


    public Sprite[] reputationImages;
    public Image containerMain;
    public void UpdateImage()
    {

        PlayerData playerData = saveManager.GetPlayerData();

        int reputationAmount = playerData.houseRepLevel;


        // Ensure that the reputation amount is within the range of available images
        if (reputationAmount >= 0 && reputationAmount < reputationImages.Length)
        {
            // Set the sprite of the Image component based on the reputation amount
            containerMain.sprite = reputationImages[reputationAmount];
        }
        else
        {
            Debug.LogError("Reputation amount is out of range!");
        }
    }

    









    // Update is called once per frame
    void Update()
    {
        
    }
}
