using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using TMPro;






[Serializable]
public class PlayerData
{
    public int scrapAmount;

  //  public string SimpleFullCompound;
    public string TopicIndex = "Room (Simple)";
    public string CategoryIndex;

    // public int[] SimplePhraseCompoundSpanishLevels; // = { 10, 20, 30, 40 };

    public int[] SimplePhraseCompoundSpanishLevels;
   




    public int SimplePhraseCompoundSpanishLevels_1;
    public int SimplePhraseCompoundSpanishLevels_2;
    public int SimplePhraseCompoundSpanishLevels_3;
 public int SimplePhraseCompoundSpanishLevels_4;
    public int SimplePhraseCompoundSpanishLevels_5;
    public int SimplePhraseCompoundSpanishLevels_6;
    public int SimplePhraseCompoundSpanishLevels_7;
 public int SimplePhraseCompoundSpanishLevels_8;
 public int SimplePhraseCompoundSpanishLevels_9;
    public int SimplePhraseCompoundSpanishLevels_10;
 public int SimplePhraseCompoundSpanishLevels_11;
 public int SimplePhraseCompoundSpanishLevels_12;
 public int SimplePhraseCompoundSpanishLevels_13;
 public int SimplePhraseCompoundSpanishLevels_14;
 public int SimplePhraseCompoundSpanishLevels_15;
 public int SimplePhraseCompoundSpanishLevels_16;
 public int SimplePhraseCompoundSpanishLevels_17;
 public int SimplePhraseCompoundSpanishLevels_18;
 public int SimplePhraseCompoundSpanishLevels_19;
    public int SimplePhraseCompoundSpanishLevels_20;
    public int SimplePhraseCompoundSpanishLevels_21;
 public int SimplePhraseCompoundSpanishLevels_22;
 public int SimplePhraseCompoundSpanishLevels_23;
 public int SimplePhraseCompoundSpanishLevels_24;
 public int SimplePhraseCompoundSpanishLevels_25;
 public int SimplePhraseCompoundSpanishLevels_26;
    public int SimplePhraseCompoundSpanishLevels_27;
 public int SimplePhraseCompoundSpanishLevels_28;
 public int SimplePhraseCompoundSpanishLevels_29;
 public int SimplePhraseCompoundSpanishLevels_30;
 public int SimplePhraseCompoundSpanishLevels_31;
    public int SimplePhraseCompoundSpanishLevels_32;
 public int SimplePhraseCompoundSpanishLevels_33;
 public int SimplePhraseCompoundSpanishLevels_34;
    public int SimplePhraseCompoundSpanishLevels_35;
 public int SimplePhraseCompoundSpanishLevels_36;
 public int SimplePhraseCompoundSpanishLevels_37;
    public int SimplePhraseCompoundSpanishLevels_38;
 public int SimplePhraseCompoundSpanishLevels_39;
    public int SimplePhraseCompoundSpanishLevels_40;
 public int SimplePhraseCompoundSpanishLevels_41;
 public int SimplePhraseCompoundSpanishLevels_42;
 public int SimplePhraseCompoundSpanishLevels_43;
    public int SimplePhraseCompoundSpanishLevels_44;
 public int SimplePhraseCompoundSpanishLevels_45;
 public int SimplePhraseCompoundSpanishLevels_46;
    public int SimplePhraseCompoundSpanishLevels_47;
 public int SimplePhraseCompoundSpanishLevels_48;
    public int SimplePhraseCompoundSpanishLevels_49;




    public int CategoryLevel1_bought;
    public int CategoryLevel2_bought;
    public int CategoryLevel3_bought;
    public int CategoryLevel4_bought;
    public int CategoryLevel5_bought;
    public int CategoryLevel6_bought;
    public int CategoryLevel7_bought;


    public int starLevel;

 

    public int flagLevel;

    public int factCardboolean_1;
    public int factCardboolean_2;
    public int factCardboolean_3;

    public int[] factCardboolean;










    public int totalWorker;
    public int totalScrapper;
    public int totalWoodcutter;

   
    public int scrapAutoProductionEfficent;
    public int scrapToWoodEfficent;

    public int playerScore;
    public int playerEnergy;
    
    public int shovelLevel;
    public int currentlocationLevel;
    public int locationLevelPurchased;
    public int miletoneAchieved;

    public int woodMillLevel;


    public int Wood;
    public int Stone;
    public int Seed;


    public int reputationAmount;
    public int cashAmount;
    public int houseRepLevel;

    // fossil, meteor, fungui, frozensample, fish, amazonplants, insects, gallium, arsenic, virus, bacteria, magnesium, sodium, plutonium, methane, chlorine, ammonia, petroelum, ruby, sapphire, diamond, marble, limestone
    // deer, lead ore, rabbit?

    // Add more data fields as needed

    // Constructor to initialize default values
    public PlayerData()
    {

        //    SimplePhraseCompoundSpanishLevels = [1, 2, 3, 4, 5, 6];
        // SimplePhraseCompoundSpanishLevels[0] = 0;
        // SimplePhraseCompoundSpanishLevels = { 10, 20, 30, 40 };


        reputationAmount = 0;

        houseRepLevel = 0;

        cashAmount = 0;
        SimplePhraseCompoundSpanishLevels_1 = 0;

        TopicIndex = "Room (Simple)";
         CategoryIndex = "Home";


           CategoryLevel1_bought=0;
      CategoryLevel2_bought=0;
      CategoryLevel3_bought=0;
      CategoryLevel4_bought=0;
      CategoryLevel5_bought=0;
      CategoryLevel6_bought=0;
      CategoryLevel7_bought=0;


        SimplePhraseCompoundSpanishLevels = new int[49];
        for (int i = 0; i < SimplePhraseCompoundSpanishLevels.Length; i++)
        {
            SimplePhraseCompoundSpanishLevels[i] = 0; // Set default value to 0 for each element
        }


        factCardboolean = new int[200];
        for (int i = 0; i < factCardboolean.Length; i++)
        {
            factCardboolean[i] = 0; // Set default value to 0 for each element
        }




        SimplePhraseCompoundSpanishLevels_1 =0;
    SimplePhraseCompoundSpanishLevels_2 = 0;
   SimplePhraseCompoundSpanishLevels_3 = 0;
  SimplePhraseCompoundSpanishLevels_4 = 0;
  SimplePhraseCompoundSpanishLevels_5 = 0;
     SimplePhraseCompoundSpanishLevels_6 = 0;
      SimplePhraseCompoundSpanishLevels_7 = 0;
      SimplePhraseCompoundSpanishLevels_8 = 0;
      SimplePhraseCompoundSpanishLevels_9 = 0;
      SimplePhraseCompoundSpanishLevels_10 = 0;
      SimplePhraseCompoundSpanishLevels_11 = 0;
      SimplePhraseCompoundSpanishLevels_12 = 0;
      SimplePhraseCompoundSpanishLevels_13 = 0;
      SimplePhraseCompoundSpanishLevels_14 = 0;
      SimplePhraseCompoundSpanishLevels_15 = 0;
   SimplePhraseCompoundSpanishLevels_16 = 0;
    SimplePhraseCompoundSpanishLevels_17 = 0;
      SimplePhraseCompoundSpanishLevels_18 = 0;
      SimplePhraseCompoundSpanishLevels_19 = 0;
  SimplePhraseCompoundSpanishLevels_20 = 0;
      SimplePhraseCompoundSpanishLevels_21 = 0;
      SimplePhraseCompoundSpanishLevels_22 = 0;
      SimplePhraseCompoundSpanishLevels_23 = 0;
    SimplePhraseCompoundSpanishLevels_24 = 0;
      SimplePhraseCompoundSpanishLevels_25 = 0;
      SimplePhraseCompoundSpanishLevels_26 = 0;
      SimplePhraseCompoundSpanishLevels_27 = 0;
      SimplePhraseCompoundSpanishLevels_28 = 0;
      SimplePhraseCompoundSpanishLevels_29 = 0;
      SimplePhraseCompoundSpanishLevels_30 = 0;
      SimplePhraseCompoundSpanishLevels_31 = 0;
      SimplePhraseCompoundSpanishLevels_32 = 0;
    SimplePhraseCompoundSpanishLevels_33 = 0;
      SimplePhraseCompoundSpanishLevels_34 = 0;
      SimplePhraseCompoundSpanishLevels_35 = 0;
 SimplePhraseCompoundSpanishLevels_36 = 0;
      SimplePhraseCompoundSpanishLevels_37 = 0;
      SimplePhraseCompoundSpanishLevels_38 = 0;
      SimplePhraseCompoundSpanishLevels_39 = 0;
      SimplePhraseCompoundSpanishLevels_40 = 0;
      SimplePhraseCompoundSpanishLevels_41 = 0;
      SimplePhraseCompoundSpanishLevels_42 = 0;
      SimplePhraseCompoundSpanishLevels_43 = 0;
      SimplePhraseCompoundSpanishLevels_44 = 0;
      SimplePhraseCompoundSpanishLevels_45 = 0;
      SimplePhraseCompoundSpanishLevels_46 = 0;
      SimplePhraseCompoundSpanishLevels_47 = 0;
      SimplePhraseCompoundSpanishLevels_48 = 0;
   SimplePhraseCompoundSpanishLevels_49 = 0;



   
        playerEnergy = 0;
        scrapAmount = 0;
        shovelLevel = 0;
 



}
}

public class SaveManager : MonoBehaviour
{
    private string dataFilePath;
    private PlayerData playerData;

    public TextMeshProUGUI debugMiletoneT;
    public TextMeshProUGUI debugLocLevelT;

    void Start()
    {
        dataFilePath = Path.Combine(Application.persistentDataPath, "playerData.dat");
        LoadPlayerData();
        StartCoroutine(SaveDataPeriodically());

     //   int firstElement = playerData.SimplePhraseCompoundSpanishLevels[0];
      //  Debug.Log(firstElement);
     //   Debug.Log(playerData.SimplePhraseCompoundSpanishLevels[0]);
        //testing
        // GeneralizedResourcePurchase("Wood", 1, "add");
    }

    void Awake()
    {
        playerData = new PlayerData();
    }






    public PlayerData GetPlayerData()
    {
        return playerData;
    }













    IEnumerator SaveDataPeriodically()
    {
        while (true)
        {
            yield return new WaitForSeconds(30f); // Reduced for testing purposes
            SavePlayerData();
        //    Debug.Log("Player data saved at interval");
        }
    }

    public void SavePlayerData()
    {
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = File.Create(dataFilePath);

            formatter.Serialize(fileStream, playerData);
            fileStream.Close();

       //     Debug.Log("Player data saved");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error saving player data: " + e.Message);
        }
    }

    public void LoadPlayerData()
    {
        try
        {
            if (File.Exists(dataFilePath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fileStream = File.Open(dataFilePath, FileMode.Open);

                playerData = (PlayerData)formatter.Deserialize(fileStream);
                fileStream.Close();

           //     Debug.Log("Player data loaded. Scrap: " + playerData.scrapAmount);
            }
            else
            {
          //      Debug.Log("No saved player data found. Creating new data.");
                SavePlayerData(); // If no data is found, save default data
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error loading player data: " + e.Message);
        }
    }

    public void DeletePlayerData()
    {
        if (File.Exists(dataFilePath))
        {
            try
            {
                File.Delete(dataFilePath);
                Debug.Log("Player data deleted");
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error deleting player data: " + e.Message);
            }
        }
        else
        {
            Debug.Log("No player data found to delete");
        }
    }



    public void IncrementMiletone()
    {
        playerData.miletoneAchieved = playerData.miletoneAchieved + 1;
        debugMiletoneT.text = "Add Miletone (" + playerData.miletoneAchieved + ")";
    }

    public void IncrementLocationPurchased()
    {
        playerData.locationLevelPurchased = playerData.locationLevelPurchased + 1;
        debugLocLevelT.text = "Add Loc Level (" + playerData.locationLevelPurchased + ")";
    }



    public void GeneralizedResourcePurchase(string resourceName, int amount, string addorsubtract)
    {

        string[] resources = { "Scrap", "Wood", "Seed" };

        int[] resourcesPlayerData = { playerData.scrapAmount, playerData.Wood, playerData.Seed };

      //  Debug.Log(resourcesPlayerData[0]);
       // resourcesPlayerData[0]++;
      //  Debug.Log(resourcesPlayerData[0]);



        if (addorsubtract == "add" || addorsubtract == "Add")
        {
            if (resourceName == "")
            {

            }

        }
        

        if (addorsubtract == "substract" || addorsubtract == "Subtract")
        {
            if (resourceName == "")
            {

            }
        }
    }


}