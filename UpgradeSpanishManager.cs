using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeSpanishManager : MonoBehaviour
{
    // Start is called before the first frame update

    public SaveManager saveManager;

    public TextMeshProUGUI rateTotal;
    public TextMeshProUGUI clickPowerTotal;
    public TextMeshProUGUI topicCurrentText; //remember to add \n simple,full, or compound
    public TextMeshProUGUI categoryCurrentText;

  //  public TextMeshProUGUI basicTopic1_TotalPurchasedText;
  //  public TextMeshProUGUI basicTopic1_CostText;

    public TextMeshProUGUI category1_PurchasedYet;


    void Start()
    {
        if (saveManager == null)
        {
            Debug.LogError("SaveManager reference not set in ScoreModifier.");
            return;
        }

        PlayerData playerData = saveManager.GetPlayerData();
    //    ShovelSlotInfo.text = "Shovel Level " + playerData.shovelLevel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buySpecificUpgradeSlot(string name)
    {


        if (name == "Shovel")
        {
            PlayerData playerData = saveManager.GetPlayerData();

            for (int i = 1000; i >= 0; i--)
            {
                if (i == playerData.shovelLevel && playerData.scrapAmount >= (playerData.shovelLevel + 1) * 100)
                {
                    playerData.scrapAmount = playerData.scrapAmount - (playerData.shovelLevel + 1) * 100;
                  //  playerData.shovelLevel++;
                    saveManager.SavePlayerData();
                //    announcerDescription.text = "Yeah, need a shovel to at least get something useful like scraps";
                //    announcerCost.text = "Cost: " + ((playerData.shovelLevel + 1) * 100) + " Scraps";
                 //   ShovelSlotInfo.text = "Shovel Level " + playerData.shovelLevel;
                }


            }

        }

    }
    }
