using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;


//need to make upgrademanager, cartographyButton, scraptoWoodcode, lootschangingbasedonmap... turn off all panels and update
public class GameManager : MonoBehaviour
{
    public SaveManager saveManager;
    public TopicCategoryManager topicCategoryManager;// Reference to the SaveManager script
    public TextMeshProUGUI scoreText;
    public UIManager uIManager;

   // public GameObject purchasedenialPopup;
    public GameObject objectToToggle; // Assign this in the inspector
    public float visibilityDuration = 2f;



    // Reference to the TextMeshProUGUI component

    void Start()
    {
        if (saveManager == null)
        {
          //  Debug.LogError("SaveManager reference not set in ScoreModifier.");
          //  return;
        }




        if (scoreText == null)
        {
        //    Debug.LogError("TextMeshProUGUI reference not set in ScoreDisplay.");
         //   return;
        }


        StartCoroutine(CallFunctionRepeatedly());
        StartCoroutine(CallFunctionRepeatedly5secondsforAuto());
        




        PlayerData playerData = saveManager.GetPlayerData();

        if (playerData != null)
        {
            // For example, increase the playerScore by 10
            playerData.scrapAmount += 0;

            // Save the modified playerData back to the file using SavePlayerData in SaveManager
            saveManager.SavePlayerData();
        }
        else
        {
            Debug.LogError("playerData is null in SaveManager.");
        }










        SimpleFullCompoundButtonsChecker();



    }



    IEnumerator CallFunctionRepeatedly()
    {
        float timer = 0f;
        float interval = 0.1f;
        float duration = 1f; // Duration for calling the function every 0.1 second

        while (timer < duration)
        {
            UpdateScoreText(); // Call your function here

            yield return new WaitForSeconds(interval);
            timer += interval;
        }

        // Reset the timer for the next phase
        timer = 0f;
        interval = 1f; // Change interval to 1 second for subsequent calls

        while (true)
        {
            UpdateScoreText(); // Call your function here

            yield return new WaitForSeconds(interval);
        }
    }



    IEnumerator CallFunctionRepeatedly5secondsforAuto()
    {


        // Reset the timer for the next phase
       // float timer = 0f;
        float interval = 5; // Change interval to 1 second for subsequent calls

        while (true)
        {
            //   UpdateScoreText(); // Call your function here
            IncrementandUpdateTextfromAutomation();
           // Debug.Log("making scrap auto");
            yield return new WaitForSeconds(interval);

        }
    }


    // Function that you want to call every second
    public void UpdateScoreText()
    {

        PlayerData playerData = saveManager.GetPlayerData();

        if (playerData != null)
        {
            // Get the player score from SaveManager's playerData
            int scrapAmount = playerData.scrapAmount;
            // Update the TextMeshProUGUI component with the playerScore
            scoreText.text = "Brainpower: " + scrapAmount.ToString();
        }
        else
        {
            Debug.LogError("playerData is null in SaveManager.");
        }
    }


    public void IncrementScore()
    {

        PlayerData playerData = saveManager.GetPlayerData();

        if (playerData != null)
        {
            // Get the player score from SaveManager's playerData



         //   topicCategoryManager.AddText();



            int scrapAmount = playerData.scrapAmount;
            playerData.scrapAmount += 1 + playerData.shovelLevel;
            // Update the TextMeshProUGUI component with the playerScore
            scoreText.text = "Brainpower: " + scrapAmount.ToString();

            saveManager.SavePlayerData();
        }
        else
        {
            Debug.LogError("playerData is null in SaveManager.");
        }
    }












    private Coroutine visibilityCoroutine; // Reference to the running coroutine

    // This method is linked to the button's OnClick event
    public void ToggleVisibility()
    {
        if (visibilityCoroutine != null)
        {
            StopCoroutine(visibilityCoroutine); // Stop the currently running coroutine
            objectToToggle.SetActive(false); // Immediately hide the object to reset its state
        }
        visibilityCoroutine = StartCoroutine(ToggleVisibilityCoroutine());
    }

    private IEnumerator ToggleVisibilityCoroutine()
    {
        objectToToggle.SetActive(true); // Make the object visible
        yield return new WaitForSeconds(visibilityDuration); // Wait for specified duration
        objectToToggle.SetActive(false); // Hide the object again
        visibilityCoroutine = null; // Reset the coroutine reference
    }






















    public GameObject[] simpleBUTTONS_ARRAY = new GameObject[49];
    public GameObject[] fullBUTTONS_ARRAY = new GameObject[49];
    public GameObject[] compoundBUTTONS_ARRAY = new GameObject[49];

    public void SimpleFullCompoundButtonsChecker()
    {
        PlayerData playerData = saveManager.GetPlayerData();
        int[] levels = new int[] {
        playerData.SimplePhraseCompoundSpanishLevels_1,
        playerData.SimplePhraseCompoundSpanishLevels_2,
        playerData.SimplePhraseCompoundSpanishLevels_3,
        playerData.SimplePhraseCompoundSpanishLevels_4,
        playerData.SimplePhraseCompoundSpanishLevels_5,
        playerData.SimplePhraseCompoundSpanishLevels_6,
        playerData.SimplePhraseCompoundSpanishLevels_7,
        playerData.SimplePhraseCompoundSpanishLevels_8,
        playerData.SimplePhraseCompoundSpanishLevels_9,
        playerData.SimplePhraseCompoundSpanishLevels_10,
        playerData.SimplePhraseCompoundSpanishLevels_11,
        playerData.SimplePhraseCompoundSpanishLevels_12,
        playerData.SimplePhraseCompoundSpanishLevels_13,
        playerData.SimplePhraseCompoundSpanishLevels_14,
        playerData.SimplePhraseCompoundSpanishLevels_15,
        playerData.SimplePhraseCompoundSpanishLevels_16,
        playerData.SimplePhraseCompoundSpanishLevels_17,
        playerData.SimplePhraseCompoundSpanishLevels_18,
        playerData.SimplePhraseCompoundSpanishLevels_19,
        playerData.SimplePhraseCompoundSpanishLevels_20,
        playerData.SimplePhraseCompoundSpanishLevels_21,
        playerData.SimplePhraseCompoundSpanishLevels_22,
        playerData.SimplePhraseCompoundSpanishLevels_23,
        playerData.SimplePhraseCompoundSpanishLevels_24,
        playerData.SimplePhraseCompoundSpanishLevels_25,
        playerData.SimplePhraseCompoundSpanishLevels_26,
        playerData.SimplePhraseCompoundSpanishLevels_27,
        playerData.SimplePhraseCompoundSpanishLevels_28,
        playerData.SimplePhraseCompoundSpanishLevels_29,

        playerData.SimplePhraseCompoundSpanishLevels_30,
        playerData.SimplePhraseCompoundSpanishLevels_31,
        playerData.SimplePhraseCompoundSpanishLevels_32,
        playerData.SimplePhraseCompoundSpanishLevels_33,
        playerData.SimplePhraseCompoundSpanishLevels_34,
        playerData.SimplePhraseCompoundSpanishLevels_35,
        playerData.SimplePhraseCompoundSpanishLevels_36,
        playerData.SimplePhraseCompoundSpanishLevels_37,
        playerData.SimplePhraseCompoundSpanishLevels_38,
        playerData.SimplePhraseCompoundSpanishLevels_39,

        playerData.SimplePhraseCompoundSpanishLevels_40,
        playerData.SimplePhraseCompoundSpanishLevels_41,
        playerData.SimplePhraseCompoundSpanishLevels_42,
        playerData.SimplePhraseCompoundSpanishLevels_43,
        playerData.SimplePhraseCompoundSpanishLevels_44,
        playerData.SimplePhraseCompoundSpanishLevels_45,
        playerData.SimplePhraseCompoundSpanishLevels_46,
        playerData.SimplePhraseCompoundSpanishLevels_47,
        playerData.SimplePhraseCompoundSpanishLevels_48,
        playerData.SimplePhraseCompoundSpanishLevels_49,



       
    };

        for (int i = 0; i < levels.Length; i++)
        {
            if (levels[i] >= 1)
            {
                simpleBUTTONS_ARRAY[i].SetActive(true);
            }
            if (levels[i] >= 5)
            {
                fullBUTTONS_ARRAY[i].SetActive(true);
            }
            if (levels[i] >= 10)
            {
                compoundBUTTONS_ARRAY[i].SetActive(true);
            }
        }
    }


    public void IncrementTopicLevel(string passing)
    {
        PlayerData playerData = saveManager.GetPlayerData();
        int brainpowerAmount = playerData.scrapAmount;

        switch (passing)
        {
            case "Room":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_1, brainpowerAmount, 0);

                break;
            case "Furniture":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_2, brainpowerAmount, 1);
                break;
            case "Backyard":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_3, brainpowerAmount, 2);
                break;
            case "Family":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_4, brainpowerAmount, 3);
                break;
            case "Utility":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_5, brainpowerAmount, 4);
                break;
            case "Decoration":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_6, brainpowerAmount, 5);
                break;
            case "Repair":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_7, brainpowerAmount, 6);
                break;
            case "Buying":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_8, brainpowerAmount, 7);

                break;
            case "Clothes":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_9, brainpowerAmount, 8);
                break;
            case "Foods":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_10, brainpowerAmount, 9);
                break;
            case "Toys":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_11, brainpowerAmount, 10);
                break;
            case "Dollars":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_12, brainpowerAmount, 11);
                break;
            case "Customer":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_13, brainpowerAmount, 12);
                break;
            case "Special Occasion":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_14, brainpowerAmount, 13);
                break;


            case "Explore":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_15, brainpowerAmount, 14);

                break;
            case "Culture":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_16, brainpowerAmount, 15);
                break;
            case "Nature":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_17, brainpowerAmount, 16);
                break;
            case "History":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_18, brainpowerAmount, 17);
                break;
            case "Relaxing":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_19, brainpowerAmount, 18);
                break;
            case "Culinary":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_20, brainpowerAmount, 19);
                break;
            case "Hidden Gem":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_21, brainpowerAmount, 20);
                break;



            case "Exercise":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_22, brainpowerAmount, 21);

                break;
            case "Nurtition":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_23, brainpowerAmount, 22);
                break;
            case "Mental Health":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_24, brainpowerAmount, 23);
                break;
            case "Sleep":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_25, brainpowerAmount, 24);
                break;
            case "Disease":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_26, brainpowerAmount, 25);
                break;
            case "Aging":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_27, brainpowerAmount, 26);
                break;
            case "Fitness":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_28, brainpowerAmount, 27);
                break;
            // Add more cases as needed



            case "Learning":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_29, brainpowerAmount, 28);

                break;
            case "College":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_30, brainpowerAmount, 29);
                break;
            case "Library":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_31, brainpowerAmount, 30);
                break;
            case "Exam":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_32, brainpowerAmount, 31);
                break;
            case "Class":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_33, brainpowerAmount, 32);
                break;
            case "Professor":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_34, brainpowerAmount, 33);
                break;
            case "Research":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_35, brainpowerAmount, 34);
                break;


            case "Job":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_36, brainpowerAmount, 35);

                break;
            case "Construction":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_37, brainpowerAmount, 36);
                break;
            case "Wage":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_38, brainpowerAmount, 37);
                break;
            case "Office":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_39, brainpowerAmount, 38);
                break;
            case "Retail":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_40, brainpowerAmount, 39);
                break;
            case "Hospital":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_41, brainpowerAmount, 40);
                break;
            case "Bank":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_42, brainpowerAmount, 41);
                break;



            case "Beach":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_43, brainpowerAmount, 42);

                break;
            case "Park":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_44, brainpowerAmount, 43);
                break;
            case "Stadium":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_45, brainpowerAmount, 44);
                break;
            case "Party":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_46, brainpowerAmount, 45);
                break;
            case "Restaurant":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_47, brainpowerAmount, 46);
                break;
            case "Internet":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_48, brainpowerAmount, 47);
                break;
            case "Movie":
                AttemptLevelUp(ref playerData.SimplePhraseCompoundSpanishLevels_49, brainpowerAmount, 48);
                break;
        }
    }

    private void AttemptLevelUp(ref int level, int brainpowerAmount, int uiIndex)
    {
        int cost = (level + 1) * 10;
        if (brainpowerAmount >= cost)
        {
            level++;
            saveManager.GetPlayerData().scrapAmount -= cost;
            
            SimpleFullCompoundButtonsChecker();
            
            UpdateUI(level, cost, uiIndex);
            saveManager.SavePlayerData();
        }
        else
        {
            ToggleVisibility();
            Debug.Log("Not enough!");
        }
    }

    private void UpdateUI(int level, int cost, int index)
    {
        string currentText = uIManager.SimplePhraseCompoundSpanishLevelsDESCRIPTION_TEXT[index].text;
        string description = currentText.Split('x')[0]; // Get the description part before 'x'
        uIManager.SimplePhraseCompoundSpanishLevelsDESCRIPTION_TEXT[index].text = $"{description}x{level}";

        uIManager.SimplePhraseCompoundSpanishLevelsCOST_TEXT[index].text = $"Cost: {(level + 1) * 10}";
    }









































    public void IncrementandUpdateTextfromAutomation()
    {

        PlayerData playerData = saveManager.GetPlayerData();

        if (playerData != null)
        {

            if (playerData.totalScrapper > 0)
            {
                playerData.scrapAmount = playerData.scrapAmount + playerData.totalScrapper + playerData.scrapAutoProductionEfficent;
                int scrapAmount = playerData.scrapAmount;
                // Update the TextMeshProUGUI component with the playerScore
                scoreText.text = "Brainpower: " + scrapAmount.ToString();
            }
        }
    }









}