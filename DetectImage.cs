using UnityEngine;
using TMPro;
using System;
using System.Collections.Generic;


using System.Reflection;
public class DetectImage : MonoBehaviour
{
 

    public TextMeshProUGUI announcerText;
    public TextMeshProUGUI brainpowerAndCostText;
    public GameObject buyButtonToggle;

    public TextMeshProUGUI flaglevelText;

    public SaveManager saveManager;
    public GameManager gameManager;
    public ArrayLibrary arrayLibrary;
    public string tagToDetect = "PassThrough1";

    // Dictionary to map each tag to its handling function for entering
    private Dictionary<string, Action> enterHandlers = new Dictionary<string, Action>();

    // Dictionary to map each tag to its handling function for exiting
    private Dictionary<string, Action> exitHandlers = new Dictionary<string, Action>();

    private void Start()
    {
        // Initialize the dictionaries with tag-handling function pairs for entering and exiting
        enterHandlers["PassThrough1"] = HandleEnterPassThrough1;
        enterHandlers["PassThrough2"] = HandleEnterPassThrough2;
        enterHandlers["PassThrough3"] = HandleEnterPassThrough3;
        enterHandlers["PassThrough4"] = HandleEnterPassThrough4;
        enterHandlers["PassThrough5"] = HandleEnterPassThrough5;
        enterHandlers["PassThrough6"] = HandleEnterPassThrough6;
        enterHandlers["PassThrough7"] = HandleEnterPassThrough7;
        enterHandlers["PassThrough8"] = HandleEnterPassThrough8;
        enterHandlers["PassThrough9"] = HandleEnterPassThrough9;
        enterHandlers["PassThrough10"] = HandleEnterPassThrough10;

        

        enterHandlers["PassThrough11"] = HandleEnterPassThrough11;
        enterHandlers["PassThrough12"] = HandleEnterPassThrough12;
        enterHandlers["PassThrough13"] = HandleEnterPassThrough13;
        enterHandlers["PassThrough14"] = HandleEnterPassThrough14;
        enterHandlers["PassThrough15"] = HandleEnterPassThrough15;
        enterHandlers["PassThrough16"] = HandleEnterPassThrough16;
        enterHandlers["PassThrough17"] = HandleEnterPassThrough17;
        enterHandlers["PassThrough18"] = HandleEnterPassThrough18;
        enterHandlers["PassThrough19"] = HandleEnterPassThrough19;
        enterHandlers["PassThrough20"] = HandleEnterPassThrough20;
        enterHandlers["PassThrough21"] = HandleEnterPassThrough21;
        enterHandlers["PassThrough22"] = HandleEnterPassThrough22;
        enterHandlers["PassThrough23"] = HandleEnterPassThrough23;
        enterHandlers["PassThrough24"] = HandleEnterPassThrough24;
        enterHandlers["PassThrough25"] = HandleEnterPassThrough25;
        enterHandlers["PassThrough26"] = HandleEnterPassThrough26;
        enterHandlers["PassThrough27"] = HandleEnterPassThrough27;
        enterHandlers["PassThrough28"] = HandleEnterPassThrough28;
        enterHandlers["PassThrough29"] = HandleEnterPassThrough29;
        enterHandlers["PassThrough30"] = HandleEnterPassThrough30;
        enterHandlers["PassThrough31"] = HandleEnterPassThrough31;
        enterHandlers["PassThrough32"] = HandleEnterPassThrough32;
        enterHandlers["PassThrough33"] = HandleEnterPassThrough33;
        enterHandlers["PassThrough34"] = HandleEnterPassThrough34;
        enterHandlers["PassThrough35"] = HandleEnterPassThrough35;
        enterHandlers["PassThrough36"] = HandleEnterPassThrough36;
        enterHandlers["PassThrough37"] = HandleEnterPassThrough37;
        enterHandlers["PassThrough38"] = HandleEnterPassThrough38;
        enterHandlers["PassThrough39"] = HandleEnterPassThrough39;
        enterHandlers["PassThrough40"] = HandleEnterPassThrough40;
        enterHandlers["PassThrough41"] = HandleEnterPassThrough41;
        enterHandlers["PassThrough42"] = HandleEnterPassThrough42;
     //   enterHandlers["PassThrough43"] = HandleEnterPassThrough43;
    //    enterHandlers["PassThrough44"] = HandleEnterPassThrough44;
   //     enterHandlers["PassThrough45"] = HandleEnterPassThrough45;
        //enterHandlers["PassThrough46"] = HandleEnterPassThrough46;
        //enterHandlers["PassThrough47"] = HandleEnterPassThrough47;
        //enterHandlers["PassThrough48"] = HandleEnterPassThrough48;
        //enterHandlers["PassThrough49"] = HandleEnterPassThrough49;
        //enterHandlers["PassThrough50"] = HandleEnterPassThrough50;


        

        //  exitHandlers["PassThrough1"] = HandleExitCommon;
        //  exitHandlers["PassThrough2"] = HandleExitCommon;
        // exitHandlers["PassThrough3"] = HandleExitCommon;

        for (int i = 1; i <= 100; i++)
        {
            string tag = "PassThrough" + i;
            exitHandlers[tag] = HandleExitCommon;
        }

        // Repeat the same for other tags if needed         
    }














    private void OnTriggerEnter2D(Collider2D other)
    {
        if (enterHandlers.ContainsKey(other.tag))
        {
            Debug.Log($"Object with {other.tag} has entered.");
            // Call the corresponding handling function for entering
            enterHandlers[other.tag]?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (exitHandlers.ContainsKey(other.tag))
        {
            Debug.Log($"Object with {other.tag} has left.");
            // Call the corresponding handling function for exiting
            exitHandlers[other.tag]?.Invoke();
        }
    }

    // Example handling functions for entering PassThrough1           factCardboolean[i] in saveManager
    void HandleEnterPassThrough1()
    {
        HandleEnterPassThrough(0);
    }

    void HandleEnterPassThrough2()
    {
        HandleEnterPassThrough(1);
    }

    void HandleEnterPassThrough3()
    {
        HandleEnterPassThrough(2);
    }

    void HandleEnterPassThrough4()
    {
        HandleEnterPassThrough(3);
    }
    void HandleEnterPassThrough5()
    {
        HandleEnterPassThrough(4);
    }
    void HandleEnterPassThrough6()
    {
        HandleEnterPassThrough(5);
    }
    void HandleEnterPassThrough7()
    {
        HandleEnterPassThrough(6);
    }
    void HandleEnterPassThrough8()
    {
        HandleEnterPassThrough(7);
    }

    void HandleEnterPassThrough9()
    {
        HandleEnterPassThrough(8);
    }

    void HandleEnterPassThrough10()
    {
        HandleEnterPassThrough(9);
    }

  

    void HandleEnterPassThrough11()
    {
        HandleEnterPassThrough(10);
    }

    void HandleEnterPassThrough12()
    {
        HandleEnterPassThrough(11);
    }

    void HandleEnterPassThrough13()
    {
        HandleEnterPassThrough(12);
    }

    void HandleEnterPassThrough14()
    {
        HandleEnterPassThrough(13);
    }

    void HandleEnterPassThrough15()
    {
        HandleEnterPassThrough(14);
    }

    void HandleEnterPassThrough16()
    {
        HandleEnterPassThrough(15);
    }

    void HandleEnterPassThrough17()
    {
        HandleEnterPassThrough(16);
    }

    void HandleEnterPassThrough18()
    {
        HandleEnterPassThrough(17);
    }

    void HandleEnterPassThrough19()
    {
        HandleEnterPassThrough(18);
    }

    void HandleEnterPassThrough20()
    {
        HandleEnterPassThrough(19);
    }

    void HandleEnterPassThrough21()
    {
        HandleEnterPassThrough(20);
    }

    void HandleEnterPassThrough22()
    {
        HandleEnterPassThrough(21);
    }

    void HandleEnterPassThrough23()
    {
        HandleEnterPassThrough(22);
    }

    void HandleEnterPassThrough24()
    {
        HandleEnterPassThrough(23);
    }

    void HandleEnterPassThrough25()
    {
        HandleEnterPassThrough(24);
    }

    void HandleEnterPassThrough26()
    {
        HandleEnterPassThrough(25);
    }

    void HandleEnterPassThrough27()
    {
        HandleEnterPassThrough(26);
    }

    void HandleEnterPassThrough28()
    {
        HandleEnterPassThrough(27);
    }

    void HandleEnterPassThrough29()
    {
        HandleEnterPassThrough(28);
    }

    void HandleEnterPassThrough30()
    {
        HandleEnterPassThrough(29);
    }

    void HandleEnterPassThrough31()
    {
        HandleEnterPassThrough(30);
    }

    void HandleEnterPassThrough32()
    {
        HandleEnterPassThrough(31);
    }

    void HandleEnterPassThrough33()
    {
        HandleEnterPassThrough(32);
    }

    void HandleEnterPassThrough34()
    {
        HandleEnterPassThrough(33);
    }

    void HandleEnterPassThrough35()
    {
        HandleEnterPassThrough(34);
    }

    void HandleEnterPassThrough36()
    {
        HandleEnterPassThrough(35);
    }

    void HandleEnterPassThrough37()
    {
        HandleEnterPassThrough(36);
    }

    void HandleEnterPassThrough38()
    {
        HandleEnterPassThrough(37);
    }

    void HandleEnterPassThrough39()
    {
        HandleEnterPassThrough(38);
    }

    void HandleEnterPassThrough40()
    {
        HandleEnterPassThrough(39);
    }

    void HandleEnterPassThrough41()
    {
        HandleEnterPassThrough(40);
    }

    void HandleEnterPassThrough42()
    {
        HandleEnterPassThrough(41);
    }

    void HandleEnterPassThrough(int index)
    {
        PlayerData playerData = saveManager.GetPlayerData();
        tagToDetect = "PassThrough" + (index + 1); // Adjust for tag indexing

        if (playerData.factCardboolean[index] == 0)
        {
            buyButtonToggle.SetActive(true);
            announcerText.text = "Locked";
        }
        else
        {
            buyButtonToggle.SetActive(false);
            flaglevelText.text = "Star: \n" + playerData.flagLevel;
            announcerText.text = arrayLibrary.WORLD_textsArray[index];
        }

        brainpowerAndCostText.text = $"Brainpower: {playerData.scrapAmount} \nCost: {(playerData.flagLevel + 1) * 50}";
    }


















































    // Example handling function for exiting common to multiple tags
    void HandleExitCommon()
    {
        buyButtonToggle.SetActive(false);
        brainpowerAndCostText.text = "Brainpower: ? \nCost: ?";
        announcerText.text = "";
        Debug.Log($"Handling exiting logic for multiple tags.");
    }

    // Define specific handling functions for other tags as needed
}
