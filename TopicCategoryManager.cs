using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopicCategoryManager : MonoBehaviour
{

    public SaveManager saveManager;
    public ArrayLibrary arrayLibrary;
    public UpgradeSpanishManager upgradeSpanishManager;
    public GameManager gameManager;

    public TextMeshProUGUI NoteText1;
    public TextMeshProUGUI NoteText2;
    public TextMeshProUGUI NoteText3;
    public TextMeshProUGUI NoteText4;
    public TextMeshProUGUI NoteText5;
    public TextMeshProUGUI NoteText6;
    public TextMeshProUGUI[] MAINtextsARRAY = new TextMeshProUGUI[6];


    public GameObject topicPanel1;
    public GameObject topicPanel2;
    public GameObject topicPanel3;
    public GameObject topicPanel4;
    public GameObject topicPanel5;
    public GameObject topicPanel6;
    public GameObject topicPanel7;




    //  private TextMeshProUGUI[]  = new TextMeshProUGUI[5];

    //  string[] Basic1_textsArray = { "dog", "cat", "mouse", "This is a <color=red>colored</color> word." };

    // Start is called before the first frame update
    string[] Basic1_textsArrayActual ;
    string[] Basic2_textsArrayActual;
    string[] Basic3_textsArrayActual;



    string[][] basicTextsArrays = new string[49][];
    string[][] FULLTextsArrays = new string[49][];
    string[][] COMPOUNDTextsArrays = new string[49][];

    void Start()
    {
        MAINtextsARRAY[0] = NoteText1;
        MAINtextsARRAY[1] = NoteText2;
        MAINtextsARRAY[2] = NoteText3;
        MAINtextsARRAY[3] = NoteText4;
        MAINtextsARRAY[4] = NoteText5;
        MAINtextsARRAY[5] = NoteText6;

 //       Basic1_textsArrayActual = arrayLibrary.Basic1_textsArray;
  //      Basic2_textsArrayActual = arrayLibrary.Basic2_textsArray;
   //     Basic3_textsArrayActual = arrayLibrary.Basic3_textsArray;



        for (int i = 0; i < basicTextsArrays.Length; i++)
        {
            // Assuming arrayLibrary contains fields named Basic1_textsArray, Basic2_textsArray, ..., Basic49_textsArray
            string fieldName = "Basic" + (i + 1) + "_textsArray";
            System.Reflection.FieldInfo field = arrayLibrary.GetType().GetField(fieldName);
            if (field != null)
            {
                basicTextsArrays[i] = (string[])field.GetValue(arrayLibrary);
            }
            else
            {
                Debug.LogError($"Field {fieldName} not found in arrayLibrary!");
            }
        }

        for (int i = 0; i < FULLTextsArrays.Length; i++)
        {
            // Assuming arrayLibrary contains fields named Basic1_textsArray, Basic2_textsArray, ..., Basic49_textsArray
            string fieldName = "Full" + (i + 1) + "_textsArray";
            System.Reflection.FieldInfo field = arrayLibrary.GetType().GetField(fieldName);
            if (field != null)
            {
                FULLTextsArrays[i] = (string[])field.GetValue(arrayLibrary);
            }
            else
            {
                Debug.LogError($"Field {fieldName} not found in arrayLibrary!");
            }
        }

        for (int i = 0; i < COMPOUNDTextsArrays.Length; i++)
        {
            // Assuming arrayLibrary contains fields named Basic1_textsArray, Basic2_textsArray, ..., Basic49_textsArray
            string fieldName = "Compound" + (i + 1) + "_textsArray";
            System.Reflection.FieldInfo field = arrayLibrary.GetType().GetField(fieldName);
            if (field != null)
            {
                COMPOUNDTextsArrays[i] = (string[])field.GetValue(arrayLibrary);
            }
            else
            {
                Debug.LogError($"Field {fieldName} not found in arrayLibrary!");
            }
        }

    }


    public void turnOffALLtopicPanels()
    {
        topicPanel1.SetActive(false);
        topicPanel2.SetActive(false);
        topicPanel3.SetActive(false);
        topicPanel4.SetActive(false);
        topicPanel5.SetActive(false);
        topicPanel6.SetActive(false);
        topicPanel7.SetActive(false);
    }


    public TextMeshProUGUI[] categoryCostARRAY = new TextMeshProUGUI[7];



    public void selectCategory(string category)
    {
        turnOffALLtopicPanels();

        PlayerData playerData = saveManager.GetPlayerData();

        int brainpowerAmount = playerData.scrapAmount;

        string categoryText = "";

        switch (category)
        {
            case "Home":
             
                    playerData.CategoryIndex = "Home";
                    categoryText = "Home";
               
                break;
            case "Shopping":
               if (playerData.CategoryLevel2_bought == 1)
                  {
                      playerData.CategoryIndex = "Shopping";
                      categoryText = "Shopping";
                     }
                else 
                {


                    if (playerData.CategoryLevel2_bought == 0 && brainpowerAmount >= 500)
                    {
                        playerData.scrapAmount = playerData.scrapAmount - 500;
                        playerData.CategoryLevel2_bought = 1;
                        categoryCostARRAY[1].text = "Cost: Purchased";//update Cost: Purchased
                        //Save
                        saveManager.SavePlayerData();
                    }
                    else { gameManager.ToggleVisibility(); }
                   
                }
                break;




            case "Travel":
                if (playerData.CategoryLevel3_bought == 1)
                {
                    playerData.CategoryIndex = "Travel";
                categoryText = "Travel";
                }
                else
                {
                    if (playerData.CategoryLevel3_bought == 0 && brainpowerAmount >= 500)
                    {
                        playerData.scrapAmount = playerData.scrapAmount - 500;
                        playerData.CategoryLevel3_bought = 1;
                        categoryCostARRAY[2].text = "Cost: Purchased";//update Cost: Purchased
                        //Save
                        saveManager.SavePlayerData();

                    }
                    else { gameManager.ToggleVisibility(); }
                }
                break;





            case "Health":
                if (playerData.CategoryLevel4_bought == 1)
                {
                    playerData.CategoryIndex = "Health";
                categoryText = "Health";
                }
                else
                {
                    if (playerData.CategoryLevel4_bought == 0 && brainpowerAmount >= 500)
                    {
                        playerData.scrapAmount = playerData.scrapAmount - 500;
                        playerData.CategoryLevel4_bought = 1;
                        categoryCostARRAY[3].text = "Cost: Purchased";//update Cost: Purchased
                        //Save
                        saveManager.SavePlayerData();

                    }
                    else { gameManager.ToggleVisibility(); }
                }
                break;
            case "School":
                if (playerData.CategoryLevel5_bought == 1)
                {
                    playerData.CategoryIndex = "School";
                categoryText = "School";
                }
                else
                {
                    if (playerData.CategoryLevel5_bought == 0 && brainpowerAmount >= 500)
                    {
                        playerData.scrapAmount = playerData.scrapAmount - 500;
                        playerData.CategoryLevel5_bought = 1;
                        categoryCostARRAY[4].text = "Cost: Purchased";//update Cost: Purchased
                        //Save
                        saveManager.SavePlayerData();
                    }
                    else { gameManager.ToggleVisibility(); }
                }
                break;
            case "Work":
                if (playerData.CategoryLevel6_bought == 1)
                {
                    playerData.CategoryIndex = "Work";
                categoryText = "Work";
                }
                else
                {
                    if (playerData.CategoryLevel6_bought == 0 && brainpowerAmount >= 500)
                    {
                        playerData.scrapAmount = playerData.scrapAmount - 500;
                        playerData.CategoryLevel6_bought = 1;
                        categoryCostARRAY[5].text = "Cost: Purchased";//update Cost: Purchased
                        //Save
                        saveManager.SavePlayerData();
                    }
                    else { gameManager.ToggleVisibility(); }
                }
                break;
            case "Fun":
                if (playerData.CategoryLevel7_bought == 1)
                {
                    playerData.CategoryIndex = "Fun";
                categoryText = "Fun";
                }
                else
                {
                    if (playerData.CategoryLevel7_bought == 0 && brainpowerAmount >= 500)
                    {
                        playerData.scrapAmount = playerData.scrapAmount - 500;
                        playerData.CategoryLevel7_bought = 1;
                        categoryCostARRAY[6].text = "Cost: Purchased";//update Cost: Purchased
                        //Save
                        saveManager.SavePlayerData();
                    }
                    else { gameManager.ToggleVisibility(); }
                }
                break;
            default:
                Debug.LogError("Unknown category: " + category);
                return; // Exit the method if the category is unknown
        }

        upgradeSpanishManager.categoryCurrentText.text = "Category:\n" + categoryText;



    }

    public void openTopicPanel()
    {
        topicPanel1.SetActive(false);
        topicPanel2.SetActive(false);
        topicPanel3.SetActive(false);
        topicPanel4.SetActive(false);
        topicPanel5.SetActive(false);
        topicPanel6.SetActive(false);
        topicPanel7.SetActive(false);

        PlayerData playerData = saveManager.GetPlayerData();
        switch (playerData.CategoryIndex)
        {
            case "Home":
                topicPanel1.SetActive(true);
                break;
            case "Shopping":
                topicPanel2.SetActive(true);
                break;
            case "Travel":
                topicPanel3.SetActive(true);
                break;
            case "Health":
                topicPanel4.SetActive(true);
                break;
            case "School":
                topicPanel5.SetActive(true);
                break;
            case "Work":
                topicPanel6.SetActive(true);
                break;
            case "Fun":
                topicPanel7.SetActive(true);
                break;
        }

    }

    public void selectTopic(string topic)
    {
     
            //  topicPanel1.SetActive(true);
            //saveManager.t;
            PlayerData playerData = saveManager.GetPlayerData();
        playerData.TopicIndex = topic;
            upgradeSpanishManager.topicCurrentText.text = "Topic:\n"+topic;
        
    }



    public void UpdateTexts()
    {
        PlayerData playerData = saveManager.GetPlayerData();

        // Define a dictionary to map topic indices to text arrays
        Dictionary<string, string[]> topicTextsMap = new Dictionary<string, string[]>()
    {
        { "Room (Simple)", basicTextsArrays[0] },
        { "Furniture (Simple)", basicTextsArrays[1] },
        { "Backyard (Simple)", basicTextsArrays[2]},
         { "Family (Simple)", basicTextsArrays[3] },
        { "Utility (Simple)", basicTextsArrays[4] },
        { "Decoration (Simple)", basicTextsArrays[5]},
         { "Repair (Simple)", basicTextsArrays[6] },

        { "Buying (Simple)", basicTextsArrays[7] },
        { "Clothes (Simple)", basicTextsArrays[8]},
         { "Foods (Simple)", basicTextsArrays[9] },
        { "Toys (Simple)", basicTextsArrays[10] },
        { "Dollars (Simple)", basicTextsArrays[11]},
         { "Customer (Simple)", basicTextsArrays[12] },
        { "Special Occasion (Simple)", basicTextsArrays[13] },

        { "Explore (Simple)", basicTextsArrays[14]},
         { "Culture (Simple)", basicTextsArrays[15] },
        { "Nature (Simple)", basicTextsArrays[16] },
        { "History (Simple)", basicTextsArrays[17]},
             { "Relaxing (Simple)", basicTextsArrays[18]},
         { "Culinary (Simple)", basicTextsArrays[19] },
        { "Hidden Gem (Simple)", basicTextsArrays[20] },


        { "Exercise (Simple)", basicTextsArrays[21]},
               { "Nurition (Simple)", basicTextsArrays[22] },
        { "Mental Health (Simple)", basicTextsArrays[23] },
        { "Sleep (Simple)", basicTextsArrays[24]},
             { "Disease (Simple)", basicTextsArrays[25]},
         { "Aging (Simple)", basicTextsArrays[26] },
        { "Fitness (Simple)", basicTextsArrays[27] },

         { "Learning (Simple)", basicTextsArrays[28]},
               { "College (Simple)", basicTextsArrays[29] },
        { "Library (Simple)", basicTextsArrays[30] },
        { "Exam (Simple)", basicTextsArrays[31]},
             { "Class (Simple)", basicTextsArrays[32]},
         { "Professor (Simple)", basicTextsArrays[33] },
        { "Research (Simple)", basicTextsArrays[34] },

         { "Job (Simple)", basicTextsArrays[35]},
               { "Construction (Simple)", basicTextsArrays[36] },
        { "Wage (Simple)", basicTextsArrays[37] },
        { "Office (Simple)", basicTextsArrays[38]},
             { "Retail (Simple)", basicTextsArrays[39]},
         { "Hospital (Simple)", basicTextsArrays[40] },
        { "Bank (Simple)", basicTextsArrays[41] },


           { "Beach (Simple)", basicTextsArrays[42]},
               { "Park (Simple)", basicTextsArrays[43] },
        { "Stadium (Simple)", basicTextsArrays[44] },
        { "Party (Simple)", basicTextsArrays[45]},
             { "Restaurant (Simple)", basicTextsArrays[46]},
         { "Internet (Simple)", basicTextsArrays[47] },
        { "Movie (Simple)", basicTextsArrays[48] },







         { "Room (Full)", FULLTextsArrays[0] },
        { "Furniture (Full)", FULLTextsArrays[1] },
        { "Backyard (Full)", FULLTextsArrays[2]},
         { "Family (Full)", FULLTextsArrays[3] },
        { "Utility (Full)", FULLTextsArrays[4] },
        { "Decoration (Full)", FULLTextsArrays[5]},
         { "Repair (Full)", FULLTextsArrays[6] },

        { "Buying (Full)", FULLTextsArrays[7] },
        { "Clothes (Full)", FULLTextsArrays[8]},
         { "Foods (Full)", FULLTextsArrays[9] },
        { "Toys (Full)", FULLTextsArrays[10] },
        { "Dollars (Full)", FULLTextsArrays[11]},
         { "Customer (Full)", FULLTextsArrays[12] },
        { "Special Occasion (Full)", FULLTextsArrays[13] },

        { "Explore (Full)", FULLTextsArrays[14]},
         { "Culture (Full)", FULLTextsArrays[15] },
        { "Nature (Full)", FULLTextsArrays[16] },
        { "History (Full)", FULLTextsArrays[17]},
             { "Relaxing (Full)", FULLTextsArrays[18]},
         { "Culinary (Full)", FULLTextsArrays[19] },
        { "Hidden Gem (Full)", FULLTextsArrays[20] },


        { "Exercise (Full)", FULLTextsArrays[21]},
               { "Nurition (Full)", FULLTextsArrays[22] },
        { "Mental Health (Full)", FULLTextsArrays[23] },
        { "Sleep (Full)", FULLTextsArrays[24]},
             { "Disease (Full)", FULLTextsArrays[25]},
         { "Aging (Full)", FULLTextsArrays[26] },
        { "Fitness (Full)", FULLTextsArrays[27] },

         { "Learning (Full)", FULLTextsArrays[28]},
               { "College (Full)", FULLTextsArrays[29] },
        { "Library (Full)", FULLTextsArrays[30] },
        { "Exam (Full)", FULLTextsArrays[31]},
             { "Class (Full)", FULLTextsArrays[32]},
         { "Professor (Full)", FULLTextsArrays[33] },
        { "Research (Full)", FULLTextsArrays[34] },

         { "Job (Full)", FULLTextsArrays[35]},
               { "Construction (Full)", FULLTextsArrays[36] },
        { "Wage (Full)", FULLTextsArrays[37] },
        { "Office (Full)", FULLTextsArrays[38]},
             { "Retail (Full)", FULLTextsArrays[39]},
         { "Hospital (Full)", FULLTextsArrays[40] },
        { "Bank (Full)", FULLTextsArrays[41] },


           { "Beach (Full)", FULLTextsArrays[42]},
               { "Park (Full)", FULLTextsArrays[43] },
        { "Stadium (Full)", FULLTextsArrays[44] },
        { "Party (Full)", FULLTextsArrays[45]},
             { "Restaurant (Full)", FULLTextsArrays[46]},
         { "Internet (Full)", FULLTextsArrays[47] },
        { "Movie (Full)", FULLTextsArrays[48] },







                 { "Room (Compound)", COMPOUNDTextsArrays[0] },
        { "Furniture (Compound)", COMPOUNDTextsArrays[1] },
        { "Backyard (Compound)", COMPOUNDTextsArrays[2]},
         { "Family (Compound)", COMPOUNDTextsArrays[3] },
        { "Utility (Compound)", COMPOUNDTextsArrays[4] },
        { "Decoration (Compound)", COMPOUNDTextsArrays[5]},
         { "Repair (Compound)", COMPOUNDTextsArrays[6] },

        { "Buying (Compound)", COMPOUNDTextsArrays[7] },
        { "Clothes (Compound)", COMPOUNDTextsArrays[8]},
         { "Foods (Compound)", COMPOUNDTextsArrays[9] },
        { "Toys (Compound)", COMPOUNDTextsArrays[10] },
        { "Dollars (Compound)", COMPOUNDTextsArrays[11]},
         { "Customer (Compound)", COMPOUNDTextsArrays[12] },
        { "Special Occasion (Compound)", COMPOUNDTextsArrays[13] },

        { "Explore (Compound)", COMPOUNDTextsArrays[14]},
         { "Culture (Compound)", COMPOUNDTextsArrays[15] },
        { "Nature (Compound)", COMPOUNDTextsArrays[16] },
        { "History (Compound)", COMPOUNDTextsArrays[17]},
             { "Relaxing (Compound)", COMPOUNDTextsArrays[18]},
         { "Culinary (Compound)", COMPOUNDTextsArrays[19] },
        { "Hidden Gem (Compound)", COMPOUNDTextsArrays[20] },


        { "Exercise (Compound)", COMPOUNDTextsArrays[21]},
               { "Nurition (Compound)", COMPOUNDTextsArrays[22] },
        { "Mental Health (Compound)", COMPOUNDTextsArrays[23] },
        { "Sleep (Compound)", COMPOUNDTextsArrays[24]},
             { "Disease (Compound)", COMPOUNDTextsArrays[25]},
         { "Aging (Compound)", COMPOUNDTextsArrays[26] },
        { "Fitness (Compound)", COMPOUNDTextsArrays[27] },

         { "Learning (Compound)", COMPOUNDTextsArrays[28]},
               { "College (Compound)", COMPOUNDTextsArrays[29] },
        { "Library (Compound)", COMPOUNDTextsArrays[30] },
        { "Exam (Compound)", COMPOUNDTextsArrays[31]},
             { "Class (Compound)", COMPOUNDTextsArrays[32]},
         { "Professor (Compound)", COMPOUNDTextsArrays[33] },
        { "Research (Compound)", COMPOUNDTextsArrays[34] },

         { "Job (Compound)", COMPOUNDTextsArrays[35]},
               { "Construction (Compound)", COMPOUNDTextsArrays[36] },
        { "Wage (Compound)", COMPOUNDTextsArrays[37] },
        { "Office (Compound)", COMPOUNDTextsArrays[38]},
             { "Retail (Compound)", COMPOUNDTextsArrays[39]},
         { "Hospital (Compound)", COMPOUNDTextsArrays[40] },
        { "Bank (Compound)", COMPOUNDTextsArrays[41] },


           { "Beach (Compound)", COMPOUNDTextsArrays[42]},
               { "Park (Compound)", COMPOUNDTextsArrays[43] },
        { "Stadium (Compound)", COMPOUNDTextsArrays[44] },
        { "Party (Compound)", COMPOUNDTextsArrays[45]},
             { "Restaurant (Compound)", COMPOUNDTextsArrays[46]},
         { "Internet (Compound)", COMPOUNDTextsArrays[47] },
        { "Movie (Compound)", COMPOUNDTextsArrays[48] },
        // Add more mappings as needed for additional topic indices
    };

        // Determine the appropriate texts array based on the topic index
        string[] textsArray = null;
        if (topicTextsMap.ContainsKey(playerData.TopicIndex))
        {
            textsArray = topicTextsMap[playerData.TopicIndex];
        }

        // Shift texts down: texts[5] becomes texts[4]'s text, and so on.
        for (int i = MAINtextsARRAY.Length - 1; i > 0; i--)
        {
            MAINtextsARRAY[i].text = MAINtextsARRAY[i - 1].text;
        }

        // Generate a new random sentence for the first text from the selected texts array
        if (textsArray != null)
        {
            int randomIndex = Random.Range(0, textsArray.Length);
            MAINtextsARRAY[0].text = textsArray[randomIndex];
        }
    }















    // Update is called once per frame
    void Update()
    {
        
    }
}
