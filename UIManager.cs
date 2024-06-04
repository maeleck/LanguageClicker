using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public SaveManager saveManager; // Reference to the SaveManager script


    public CraftInventoryManager craftInventoryManager;
    public MapManager mapManager;
    public FacilityManager facilityManager;
    public UpgradeManager upgradeManager;





    public TextMeshProUGUI[] SimplePhraseCompoundSpanishLevelsDESCRIPTION_TEXT = new TextMeshProUGUI[49];
    public TextMeshProUGUI[] SimplePhraseCompoundSpanishLevelsCOST_TEXT = new TextMeshProUGUI[49];
































    public TextMeshProUGUI locationLabelText;
    public TextMeshProUGUI locationGameLabelText;


    public GameObject upgradePanel1;
    public GameObject upgradePanel2;
    public GameObject upgradePanel3;
    public GameObject upgradePanel4;
    public GameObject upgradePanel5;
    public GameObject upgradePanel6;
    public GameObject upgradePanel7;
    public GameObject upgradePanel8;
    public GameObject upgradePanel9;
    public GameObject upgradePanel10;
    public GameObject upgradePanel11;




    public GameObject reourceSlot1;
    public GameObject reourceSlot2;
    public GameObject reourceSlot3;
    public GameObject reourceSlot4;
    public GameObject reourceSlot5;
    public GameObject reourceSlot6;
    public GameObject reourceSlot7;
    public GameObject reourceSlot8;
    public GameObject reourceSlot9;
    public GameObject reourceSlot10;
    public GameObject reourceSlot11;
    public GameObject reourceSlot12;
    public GameObject reourceSlot13;
    public GameObject reourceSlot14;
    public GameObject reourceSlot15;
    public GameObject reourceSlot16;
    public GameObject reourceSlot17;
    public GameObject reourceSlot18;
    public GameObject reourceSlot19;
    public GameObject reourceSlot20;

    public GameObject equipSlot1;
    public GameObject equipSlot2;
    public GameObject equipSlot3;
    public GameObject equipSlot4;
    public GameObject equipSlot5;
    public GameObject equipSlot6;
    public GameObject equipSlot7;
    public GameObject equipSlot8;
    public GameObject equipSlot9;
    public GameObject equipSlot10;
    public GameObject equipSlot11;
    public GameObject equipSlot12;
    public GameObject equipSlot13;
    public GameObject equipSlot14;
    public GameObject equipSlot15;
    public GameObject equipSlot16;
    public GameObject equipSlot17;
    public GameObject equipSlot18;
    public GameObject equipSlot19;
    public GameObject equipSlot20;

    public GameObject defSlot1;
    public GameObject defSlot2;
    public GameObject defSlot3;
    public GameObject defSlot4;
    public GameObject defSlot5;
    public GameObject defSlot6;
    public GameObject defSlot7;
    public GameObject defSlot8;
    public GameObject defSlot9;
    public GameObject defSlot10;
    public GameObject defSlot11;
    public GameObject defSlot12;
    public GameObject defSlot13;
    public GameObject defSlot14;
    public GameObject defSlot15;
    public GameObject defSlot16;
    public GameObject defSlot17;
    public GameObject defSlot18;
    public GameObject defSlot19;
    public GameObject defSlot20;

    public GameObject recipeSlot1;
    public GameObject recipeSlot2;
    public GameObject recipeSlot3;
    public GameObject recipeSlot4;
    public GameObject recipeSlot5;
    public GameObject recipeSlot6;
    public GameObject recipeSlot7;
    public GameObject recipeSlot8;
    public GameObject recipeSlot9;
    public GameObject recipeSlot10;
    public GameObject recipeSlot11;
    public GameObject recipeSlot12;
    public GameObject recipeSlot13;
    public GameObject recipeSlot14;
    public GameObject recipeSlot15;
    public GameObject recipeSlot16;
    public GameObject recipeSlot17;
    public GameObject recipeSlot18;
    public GameObject recipeSlot19;
    public GameObject recipeSlot20;

    public GameObject facilitySlot1;
    public GameObject facilitySlot2;
    public GameObject facilitySlot3;
    public GameObject facilitySlot4;
    public GameObject facilitySlot5;
    public GameObject facilitySlot6;
    public GameObject facilitySlot7;
    public GameObject facilitySlot8;
    public GameObject facilitySlot9;
    public GameObject facilitySlot10;
    public GameObject facilitySlot11;
    public GameObject facilitySlot12;
    public GameObject facilitySlot13;
    public GameObject facilitySlot14;
    public GameObject facilitySlot15;
    public GameObject facilitySlot16;
    public GameObject facilitySlot17;
    public GameObject facilitySlot18;
    public GameObject facilitySlot19;
    public GameObject facilitySlot20;







    public GameObject rightarrowResource;
    public GameObject rightarrowEquip;
    public GameObject rightarrowRecipe;
    public GameObject rightarrowSpecial;

    private GameObject[] gameObjectsALLUpgradePanel;

    private string currentSlotName;

    private string currentFacilityName;


    private string currentCraftName;
    // private GameObject[] gameObjectsFOURUpgradePanel = new GameObject[] { GameObject.Find("ReourceUpgradePanel"), GameObject.Find("EquipLV1UpgradePanel"), GameObject.Find("RecipeLV1UpgradePanel"), GameObject.Find("pecialLV1UpgradePanel") };





    void Start()
    {
        if (saveManager == null)
        {
           // Debug.LogError("SaveManager reference not set in ScoreDisplay.");
         //   return;
        }

        //  PlayerData playerData = saveManager.GetPlayerData();










        gameObjectsALLUpgradePanel = new GameObject[] { upgradePanel1, upgradePanel2, upgradePanel3, upgradePanel4, upgradePanel5, upgradePanel6, upgradePanel7, upgradePanel8, upgradePanel9, upgradePanel10, upgradePanel11 };
        

        //  print(gameObjectsALLUpgradePanel[1]);
    }

    private void Awake()
    {
      //  StartCoroutine(LoadSaveStaatsforALLPANELS());
    }

    IEnumerator LoadSaveStaatsforALLPANELS()
    {
        imageObjectPowerCraft.SetActive(true);
        imageObjectStats.SetActive(true);
        imageObjectOption.SetActive(true);
        imageObjectFacility.SetActive(true);
        imageObjectInventory.SetActive(true);
        imageObject.SetActive(true);

        //Wait here
        yield return new WaitForSeconds(0.1f);
        imageObjectPowerCraft.SetActive(false);
        imageObjectStats.SetActive(false);
        imageObjectOption.SetActive(false);
        imageObjectFacility.SetActive(false);
        imageObjectInventory.SetActive(false);
        imageObject.SetActive(false);

    }















































    public void ConsultCartography()
    {

        //  PlayerData playerData = saveManager.GetPlayerData();

        mapManager.buyNewArea();
    }






    public void CycleNextLocation()
    {

        PlayerData playerData = saveManager.GetPlayerData();

        // print(mapManager.getLocationList(playerData.currentlocationLevel));




        if (playerData.currentlocationLevel == playerData.locationLevelPurchased)
        {
            //  mapManager.buyNewArea();
            mapManager.beyondarea();
            mapManager.resourcenodesChecker();

        }
        if (playerData.currentlocationLevel < playerData.locationLevelPurchased)
        {
            mapManager.goingbackArea();
            playerData.currentlocationLevel++;
            locationLabelText.text = mapManager.getLocationList(playerData.currentlocationLevel);
            locationGameLabelText.text = "Location: " + locationLabelText.text;
            mapManager.resourcenodesChecker();
        }



    }


    public void CyclePreviouLocation()
    {

        PlayerData playerData = saveManager.GetPlayerData();

        // print(mapManager.getLocationList(playerData.currentlocationLevel));




        if (playerData.currentlocationLevel == playerData.locationLevelPurchased)
        {
            //   mapManager.buyNewArea();


        }


        if (playerData.currentlocationLevel == 0)
        {

            mapManager.originalarea();
            locationLabelText.text = mapManager.getLocationList(playerData.currentlocationLevel);
            mapManager.resourcenodesChecker();  
        }


        if (playerData.currentlocationLevel >= 1)
        {

            playerData.currentlocationLevel--;
            mapManager.goingbackArea();
            locationLabelText.text = mapManager.getLocationList(playerData.currentlocationLevel);
            locationGameLabelText.text = "Location: " + locationLabelText.text;
            mapManager.resourcenodesChecker();
        }



    }






























    public void SlotUpgradeCaller(string name)
    {
        currentSlotName = name;
        upgradeManager.returnSpecificUpgradePlayerData(currentSlotName);
    }

    public void BuyUpgradeSlot()
    {

        upgradeManager.buySpecificUpgradeSlot(currentSlotName);
    }


    public void SlotFacilityCaller(string name)
    {
        currentFacilityName = name;
        facilityManager.returnSpecificFacilityPlayerData(currentFacilityName);
    }

    public void AddWorkerFacilitySlot(string name)
    {
      facilityManager.addWorkertoSpecificFacilitySlot(name);
       // Debug.Log("clicked");
    }
    public void RemoveWorkerFacilitySlot(string name)
    {
        facilityManager.removeWorkertoSpecificFacilitySlot(name);
    }


    //  public void SlotCraftCaller(string name)
    // {
    //    currentCraftName = name;
    //   craftInventoryManager.returnSpecificCraftPlayerData(currentCraftName);
    // }

    public void BuyCraftSlot(string name)
    {

        craftInventoryManager.buySpecificCraftSlot(name);
    }

















    private void DeactivateAllGameObjects()
    {
        // Deactivate all GameObjects
        foreach (GameObject obj in gameObjectsALLUpgradePanel)
        {
            obj.SetActive(false);
        }
    }

    public void ActivateGameObject(int index)
    {
        // Deactivate all GameObjects first
        DeactivateAllGameObjects();

        // Activate the GameObject associated with the clicked button
        if (index >= 0 && index < gameObjectsALLUpgradePanel.Length)
        {
            gameObjectsALLUpgradePanel[index].SetActive(true);
        }


        if (index == 0)
        {
            rightarrowResource.SetActive(true);
            rightarrowEquip.SetActive(false);
            rightarrowRecipe.SetActive(false);
            rightarrowSpecial.SetActive(false);
        }

        if (index == 3)
        {
            rightarrowResource.SetActive(false);
            rightarrowEquip.SetActive(true);
            rightarrowRecipe.SetActive(false);
            rightarrowSpecial.SetActive(false);
        }

        if (index == 6)
        {
            rightarrowResource.SetActive(false);
            rightarrowEquip.SetActive(false);
            rightarrowRecipe.SetActive(true);
            rightarrowSpecial.SetActive(false);
            upgradeManager.updateUPRADErecipeinfo();
        }
        if (index == 9)
        {
            rightarrowResource.SetActive(false);
            rightarrowEquip.SetActive(false);
            rightarrowRecipe.SetActive(false);
            rightarrowSpecial.SetActive(true);
            upgradeManager.updateUPRADErecipeinfo();
        }


    }

    int counter = 0;
    public void CycleNext3GameObject(int index)
    {
        // Deactivate all GameObjects first
        DeactivateAllGameObjects();

        if (index < 7)
        {
            // Activate the GameObject associated with the clicked button
            if (counter < 2)
            {
                counter++;
                gameObjectsALLUpgradePanel[index + counter].SetActive(true);
            }
            else counter = 0; gameObjectsALLUpgradePanel[index].SetActive(true);
        }

        if (index > 7)
        {
            if (counter < 1)
            {
                counter++;
                gameObjectsALLUpgradePanel[index + counter].SetActive(true);
            }
            else counter = 0; gameObjectsALLUpgradePanel[index].SetActive(true);
        }
    }































    public void closeAll()
    {
        imageObject.SetActive(false);
        imageObjectStats.SetActive(false);
        imageObjectInventory.SetActive(false);
        imageObjectFacility.SetActive(false);
        imageObjectPowerCraft.SetActive(false);
        imageObjectOption.SetActive(false);
        imageObjectHOUSECraft.SetActive(false);
        imageObjectCITYCraft.SetActive(false);
        imageObjectDictionary.SetActive(false);
        imageObjectMINIGAME.SetActive(false);
        imageObjectCOLLECTION.SetActive(false);
    }











    public GameObject imageObject; // Reference to the GameObject containing the image
   // private bool switchState = false;
    public void ToggleCraftMenu()
    {
        // Toggle the boolean value on each click
      //  switchState = !switchState;


        // Activate or deactivate the image based on the toggle state
        if (imageObject.activeSelf == false)
        {
            imageObject.SetActive(true);
            imageObjectStats.SetActive(false);
            imageObjectCITYCraft.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectPowerCraft.SetActive(false);
            imageObjectOption.SetActive(false);
            imageObjectHOUSECraft.SetActive(false);
            imageObjectDictionary.SetActive(false);
            imageObjectMINIGAME.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);
            upgradeManager.GenerateGridUpgradeManager();
            upgradeManager.updateUPRADERESOURCEinfo();
        }

        else { imageObject.SetActive(false); upgradeManager.DestroyGrid(); }



    }




    public GameObject imageObjectOption; // Reference to the GameObject containing the image
 //   private bool switchStateOption = false;
    public void ToggleOptionMenu()
    {
        // Toggle the boolean value on each click
   //     switchStateOption = !switchStateOption;

        // Activate or deactivate the image based on the toggle state
        if (imageObjectOption.activeSelf == false)
        {
            imageObjectOption.SetActive(true);
            imageObjectStats.SetActive(false);
            imageObjectCITYCraft.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectPowerCraft.SetActive(false);
            imageObject.SetActive(false);
            imageObjectHOUSECraft.SetActive(false);
            imageObjectDictionary.SetActive(false);
            imageObjectMINIGAME.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);
        }
       // else { imageObjectOption.SetActive(false); }
    }






    public GameObject imageObjectInventory; // Reference to the GameObject containing the image
    public GameObject annoyingTopic1Button;
   // private bool switchStateInventory = false;
    public void ToggleInventoryMenu()
    {
        // Toggle the boolean value on each click
    //    switchStateInventory = !switchStateInventory;

        // Activate or deactivate the image based on the toggle state
        if (imageObjectInventory.activeSelf == false)
        {
            imageObjectInventory.SetActive(true);
            imageObjectStats.SetActive(false);
            imageObjectCITYCraft.SetActive(false);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectPowerCraft.SetActive(false);
            imageObject.SetActive(false);
            imageObjectHOUSECraft.SetActive(false);
        //    imageObjectDictionary.SetActive(false);
            imageObjectMINIGAME.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);
            annoyingTopic1Button.SetActive(false);
        }
      //  else { imageObjectInventory.SetActive(false); }

    }



    public GameObject imageObjectFacility; // Reference to the GameObject containing the image
   // private bool switchStateFacility = false;
    public void ToggleFacilityMenu()
    {
        // Toggle the boolean value on each click
  //      switchStateFacility = !switchStateFacility;

        // Activate or deactivate the image based on the toggle state
        if (imageObjectFacility.activeSelf == false)
        {
            imageObjectFacility.SetActive(true);
            imageObjectStats.SetActive(false);
            imageObjectCITYCraft.SetActive(false);
            imageObjectOption.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObjectPowerCraft.SetActive(false);
            imageObjectHOUSECraft.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);
            imageObjectDictionary.SetActive(false);
            imageObjectMINIGAME.SetActive(false);

            imageObject.SetActive(false);

        //    facilityManager.updateFACILITYinfo();
        }
     //   else { imageObjectFacility.SetActive(false); }
    }


    public GameObject imageObjectStats; // Reference to the GameObject containing the image
  //  private bool switchStateStats = false;
    public void ToggleStatsMenu()
    {
        // Toggle the boolean value on each click
        //     switchStateStats = !switchStateStats;
        imageObjectPRESTIGE.SetActive(false);
        imageObjectSTATS.SetActive(false);
        imageObjectOPTION.SetActive(false);
      //  imageObjectMINIMAP.SetActive(false);
        imageObjectRENOVATION.SetActive(false);
        // Activate or deactivate the image based on the toggle state
        if (imageObjectStats.activeSelf == false)
        {
            imageObjectStats.SetActive(true);
            imageObjectInventory.SetActive(false);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectPowerCraft.SetActive(false);
            imageObject.SetActive(false);
            imageObjectHOUSECraft.SetActive(false);
            imageObjectCITYCraft.SetActive(false);
            imageObjectDictionary.SetActive(false);
            imageObjectMINIGAME.SetActive(false);
            imageObjectPRESTIGE.SetActive(false);
            imageObjectSTATS.SetActive(false);
            imageObjectOPTION.SetActive(false);
            // imageObjectMINIMAP.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);
        }
      //  else { imageObjectStats.SetActive(false); }
    }


    public GameObject imageObjectPowerCraft; // Reference to the GameObject containing the image
   // private bool switchStatePowerCraft = false;
    public void ToggleCraftPowerMenu()
    {
        // Toggle the boolean value on each click
   //     switchStatePowerCraft = !switchStatePowerCraft;

        // Activate or deactivate the image based on the toggle state
        if (imageObjectPowerCraft.activeSelf == false)
        {
            imageObjectPowerCraft.SetActive(true);
            imageObjectStats.SetActive(false);
            imageObjectCITYCraft.SetActive(false);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);
            imageObjectHOUSECraft.SetActive(false);
         //   imageObjectDictionary.SetActive(false);
            imageObjectMINIGAME.SetActive(false);
            craftInventoryManager.updateCRAFTinfo();
            imageObjectCOLLECTION.SetActive(false);

        }
     //   else { imageObjectPowerCraft.SetActive(false); }
    }


    public TextMeshProUGUI announcerInitialText;
    public GameObject imageObjectHOUSECraft; // Reference to the GameObject containing the image
                                             // private bool switchStatePowerCraft = false;
    public void ToggleHOUSEMenu()
    {
        // Toggle the boolean value on each click
        //     switchStatePowerCraft = !switchStatePowerCraft;

        // Activate or deactivate the image based on the toggle state
        if (imageObjectHOUSECraft.activeSelf == false)
        {

            announcerInitialText.text = "Spend your brainpower here!\n<color=red> ¡Gasta tu capacidad intelectual aquí!";

            imageObjectHOUSECraft.SetActive(true);
            imageObjectCITYCraft.SetActive(false);
            imageObjectPowerCraft.SetActive(false);
            imageObjectStats.SetActive(false);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);
            imageObjectDictionary.SetActive(false);
            imageObjectMINIGAME.SetActive(false);
            craftInventoryManager.updateCRAFTinfo();
            imageObjectCOLLECTION.SetActive(false);

        }
        //   else { imageObjectPowerCraft.SetActive(false); }
    }



    public GameObject imageObjectCITYCraft; // Reference to the GameObject containing the image
                                             // private bool switchStatePowerCraft = false;
    public void ToggleCITYMenu()
    {
        // Toggle the boolean value on each click
        //     switchStatePowerCraft = !switchStatePowerCraft;

        // Activate or deactivate the image based on the toggle state
        if (imageObjectCITYCraft.activeSelf == false)
        {
            imageObjectCITYCraft.SetActive(true);
            imageObjectHOUSECraft.SetActive(false);
            imageObjectPowerCraft.SetActive(false);
            imageObjectStats.SetActive(false);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);
            imageObjectDictionary.SetActive(false);
            imageObjectMINIGAME.SetActive(false);
            craftInventoryManager.updateCRAFTinfo();

            imageObjectCOLLECTION.SetActive(false);
        }
        //   else { imageObjectPowerCraft.SetActive(false); }
    }




    public GameObject imageObjectDictionary; // Reference to the GameObject containing the image
                                            // private bool switchStatePowerCraft = false;
    public void ToggleDictionryMenu()
    {
        // Toggle the boolean value on each click
        //     switchStatePowerCraft = !switchStatePowerCraft;

        // Activate or deactivate the image based on the toggle state
        if (imageObjectDictionary.activeSelf == false)

        {

            imageObjectDictionary.SetActive(true);

            annoyingTopic1Button.SetActive(true);

            imageObjectMINIGAME.SetActive(false);
            imageObjectCITYCraft.SetActive(false);
            imageObjectHOUSECraft.SetActive(false);
            imageObjectPowerCraft.SetActive(false);
            imageObjectStats.SetActive(false);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);
            craftInventoryManager.updateCRAFTinfo();

        }
        //   else { imageObjectPowerCraft.SetActive(false); }
    }



    public GameObject imageObjectMINIGAME; // Reference to the GameObject containing the image
                                             // private bool switchStatePowerCraft = false;
    public void ToggleMINIGAMEMenu()
    {
        // Toggle the boolean value on each click
        //     switchStatePowerCraft = !switchStatePowerCraft;

        // Activate or deactivate the image based on the toggle state
        if (imageObjectMINIGAME.activeSelf == false)

        {
            imageObjectMINIGAME.SetActive(true);
            imageObjectDictionary.SetActive(false);
            imageObjectCITYCraft.SetActive(false);
            imageObjectHOUSECraft.SetActive(false);
            imageObjectPowerCraft.SetActive(false);
            imageObjectStats.SetActive(false);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);
            craftInventoryManager.updateCRAFTinfo();

        }
        //   else { imageObjectPowerCraft.SetActive(false); }
    }











    public GameObject imageObjectPRESTIGE; // Reference to the GameObject containing the image
    public GameObject imageObjectSTATS;

    public GameObject imageObjectRENOVATION;
    public GameObject imageObjectCOLLECTION;
    // Reference to the GameObject containing the image
    public GameObject imageObjectOPTION;
  //  public GameObject imageObjectMINIMAP;// Reference to the GameObject containing the image


    public void ToggleInnerMapMenu(string pass)
    {
        // Toggle the boolean value on each click
        //     switchStatePowerCraft = !switchStatePowerCraft;

        // Activate or deactivate the image based on the toggle state
        if (pass == "Prestige" && imageObjectPRESTIGE.activeSelf == false)
        {
            imageObjectPowerCraft.SetActive(false);
            imageObjectStats.SetActive(true);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);

            imageObjectPRESTIGE.SetActive(true);
            imageObjectSTATS.SetActive(false);
            imageObjectOPTION.SetActive(false);
        //    imageObjectMINIMAP.SetActive(false);
            imageObjectRENOVATION.SetActive(false);

        }

        if (pass == "Stats" && imageObjectSTATS.activeSelf == false)
        {
            imageObjectPowerCraft.SetActive(false);
            imageObjectStats.SetActive(true);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);

            imageObjectPRESTIGE.SetActive(false);
            imageObjectSTATS.SetActive(true);
            imageObjectOPTION.SetActive(false);
         //   imageObjectMINIMAP.SetActive(false);
            imageObjectRENOVATION.SetActive(false);
        }

        if (pass == "Renovation" && imageObjectRENOVATION.activeSelf == false)
        {
            imageObjectPowerCraft.SetActive(false);
            imageObjectStats.SetActive(true);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);
          

            imageObjectPRESTIGE.SetActive(false);
            imageObjectSTATS.SetActive(false);
            imageObjectRENOVATION.SetActive(true);
            imageObjectOPTION.SetActive(false);
            imageObjectCOLLECTION.SetActive(false);
            //   imageObjectMINIMAP.SetActive(false);

        }

        if (pass == "Collection" && imageObjectCOLLECTION.activeSelf == false)
        {
            imageObjectRENOVATION.SetActive(false);

            imageObjectStats.SetActive(true);
            
            imageObjectCOLLECTION.SetActive(true);

            imageObjectPowerCraft.SetActive(false);
         
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);

            imageObjectPRESTIGE.SetActive(false);
            imageObjectSTATS.SetActive(false);
            imageObjectRENOVATION.SetActive(false);
            imageObjectOPTION.SetActive(false);
            //   imageObjectMINIMAP.SetActive(false);

        }

        if (pass == "Option" && imageObjectOPTION.activeSelf == false)
        {
            imageObjectPowerCraft.SetActive(false);
            imageObjectStats.SetActive(true);
            imageObjectOption.SetActive(false);
            imageObjectFacility.SetActive(false);
            imageObjectInventory.SetActive(false);
            imageObject.SetActive(false);

            imageObjectCOLLECTION.SetActive(false);

            imageObjectPRESTIGE.SetActive(false);
            imageObjectSTATS.SetActive(false);
            imageObjectOPTION.SetActive(true);
            imageObjectRENOVATION.SetActive(false);
       //     imageObjectMINIMAP.SetActive(false);

        }


        //   else { imageObjectPowerCraft.SetActive(false); }
    }









}