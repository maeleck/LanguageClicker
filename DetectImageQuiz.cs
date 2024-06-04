using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectImageQuiz : MonoBehaviour



{
    public SaveManager saveManager;

    public TextMeshProUGUI announcerText;
    public GameObject announcerTextToggle;

    public TextMeshProUGUI brainpowerAndCostText;
    public TextMeshProUGUI starlevelText;
    public GameObject AButtonToggle;
    public GameObject BButtonToggle;
    public GameObject CButtonToggle;
    public GameObject DButtonToggle;

    public QuizManager quizManager;



    public GameObject[] buttons;


    public TextMeshProUGUI correctorIncorrectText;
    void Start()
    {
        announcerTextToggle.SetActive(false);

        PlayerData playerData = saveManager.GetPlayerData();
        starlevelText.text = "Star: \n"+playerData.starLevel.ToString();

        ShuffleButtons();




    }

    public string tagToDetect = "PassThrough1";
    // Assume you have a list or array of tags you're interested in
    public string[] interestedTags = {
    "PassThrough1", "PassThrough2", "PassThrough3", "PassThrough4", "PassThrough5",
    "PassThrough6", "PassThrough7", "PassThrough8", "PassThrough9", "PassThrough10",
    "PassThrough11", "PassThrough12", "PassThrough13", "PassThrough14", "PassThrough15",
    "PassThrough16", "PassThrough17", "PassThrough18", "PassThrough19", "PassThrough20",
    "PassThrough21", "PassThrough22", "PassThrough23", "PassThrough24", "PassThrough25",
    "PassThrough26", "PassThrough27", "PassThrough28", "PassThrough29", "PassThrough30",
    "PassThrough31", "PassThrough32", "PassThrough33", "PassThrough34", "PassThrough35",
    "PassThrough36", "PassThrough37", "PassThrough38", "PassThrough39", "PassThrough40",
    "PassThrough41", "PassThrough42", "PassThrough43", "PassThrough44", "PassThrough45",
    "PassThrough46", "PassThrough47", "PassThrough48", "PassThrough49", "PassThrough50",
    "PassThrough51", "PassThrough52", "PassThrough53", "PassThrough54", "PassThrough55"
   
};




    List<string> interestedTagsList = new List<string>();

// Add Passthrough100 tags to the list dynamically




private void OnTriggerEnter2D(Collider2D other)
    {
        // Loop through the list of tags for entering objects
        foreach (string tag in interestedTags)
        {
            if (other.CompareTag(tag))
            {

                tagToDetect = tag;
                Debug.Log($"Object with {tag} has entered.");
                // Call a function or perform actions specific to the object entering
                HandleObjectEnter(tag);
                break; // Exit the loop once the matching tag is found and handled
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Loop through the list of tags for exiting objects
        foreach (string tag in interestedTags)
        {
            if (other.CompareTag(tag))
            {
                Debug.Log($"Object with {tag} has left.");
                // Call a function or perform actions specific to the object leaving
                HandleObjectLeave(tag);
                break; // Exit the loop once the matching tag is found and handled
            }
        }
    }

    // Example handler function for entering
    void HandleObjectEnter(string tag)
    {
        PlayerData playerData = saveManager.GetPlayerData();
        bool isReady = false;
        int index = -1;

        if (tag.StartsWith("PassThrough") && int.TryParse(tag.Substring(11), out int number))
        {
            // Subtract 1 from the number to get the index (e.g., "PassThrough1" corresponds to index 0)
            quizManager.OpenQuizPanel(number-1,  quizManager.arrayQuestionIndex[number-1]   )   ;
            index = number - 1;
        }

        if (index != -1 && index < quizManager.star_cooldownValues.Length && quizManager.star_cooldownValues[index] == "Ready")
        {
            isReady = true;
        }

        AButtonToggle.SetActive(isReady);
        BButtonToggle.SetActive(isReady);
        CButtonToggle.SetActive(isReady);
        DButtonToggle.SetActive(isReady);
     //   ShuffleButtons();
        brainpowerAndCostText.text = "Brainpower: " + playerData.scrapAmount + " \nCost: " + (playerData.starLevel + 1) * 10;
        announcerTextToggle.SetActive(isReady);
        correctorIncorrectText.text = isReady ? "" : "(wait for reset)";

        Debug.Log($"Handle entering logic for {tag}.");
    }

    // Example handler function for leaving
    void HandleObjectLeave(string tag)
    {
        AButtonToggle.SetActive(false);
        BButtonToggle.SetActive(false);
        CButtonToggle.SetActive(false);
        DButtonToggle.SetActive(false);
        announcerTextToggle.SetActive(false);
        correctorIncorrectText.text = "";
        // Handle the logic for when an object leaves
        brainpowerAndCostText.text = "Brainpower: ? \nCost: ?";
    //    announcerText.text = "";
        Debug.Log($"Handle leaving logic for {tag}.");
    }












    void ShuffleButtons()
    {
        List<GameObject> buttons = new List<GameObject> { AButtonToggle, BButtonToggle, CButtonToggle, DButtonToggle };
        List<Vector3> positions = new List<Vector3>();

        // Store the initial positions of the buttons
        foreach (GameObject button in buttons)
        {
            positions.Add(button.transform.position);
        }

        // Shuffle the list of positions
        for (int i = 0; i < positions.Count; i++)
        {
            Vector3 temp = positions[i];
            int randomIndex = Random.Range(i, positions.Count);
            positions[i] = positions[randomIndex];
            positions[randomIndex] = temp;
        }

        // Assign new positions to the buttons
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].transform.position = positions[i];
        }
    }
}
