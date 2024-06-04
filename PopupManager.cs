using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupManager : MonoBehaviour
{
    public GameObject popupPrefab;
    public int maxNumberOfPopups = 15; // Set the maximum number of popups
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 5f;
    public float popupLifetime = 5f;
    public GameObject innerpanel;
    public ArrayLibrary arrayLibrary;
    public int popupGroupIndex = 0; // Index of the popup group in the arrayLibrary

  //  private Camera mainCamera; // Reference to the main camera

    void Start()
    {
      //  mainCamera = Camera.main;
        // Start the coroutine to continuously spawn popups
       // StartCoroutine(SpawnPopups());
    }


    // IEnumerator SpawnPopups()
    public void SpawnPopups(int groupIndex)
    {
        popupGroupIndex = groupIndex;

      
            // Check if the number of popups is less than the maximum allowed
            if (GetNumberOfPopups() < maxNumberOfPopups)
            {
                // Instantiate a new popup
                GameObject popup = Instantiate(popupPrefab, GetRandomPosition(), Quaternion.identity, innerpanel.transform);
                popup.SetActive(true);

                // Modify the text of the popup (assuming it has a Text component)
                TextMeshProUGUI textMesh = popup.GetComponentInChildren<TextMeshProUGUI>();
                if (textMesh != null)
                {
                    string[] popupGroup = GetPopupGroup();
                    int arrayLength = popupGroup.Length;

                    // Generate a random index within the array bounds
                    int randomIndex = Random.Range(0, arrayLength);

                    // Assign the randomly selected element to textMesh.text
                    textMesh.text = popupGroup[randomIndex];
                }

                // Destroy the popup after the specified lifetime
                Destroy(popup, popupLifetime);
            }

            // Wait for a random interval before spawning the next popup
         //   float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
         //   yield return new WaitForSeconds(spawnInterval);
        
    }

    int GetNumberOfPopups()
    {
        // Count the number of child objects under the inner panel
        return innerpanel.transform.childCount;
    }

    Vector3 GetRandomPosition()
    {
        // Generate a random position within the inner panel boundaries
        float minX = 50/* Minimum X coordinate */;
        float maxX = 300/* Maximum X coordinate */;
        float minY = 200/* Minimum Y coordinate */;
        float maxY = 400/* Maximum Y coordinate */;

        // Adjust the random position based on the popup group index
        switch (popupGroupIndex)
        {
            case 1:
                minX = 0; maxX = 0; minY = 0; maxY = 0;
                break;
            case 2:
                minX = 0; maxX = 0; minY = 1200; maxY = 1300;
                break;

            case 3:
                minX = 0; maxX = 0; minY = 2300; maxY = 2500;
                break;

            case 4:
                minX = 0; maxX = 0; minY = 3200; maxY = 3300;
                break;

            case 5:
                minX = 0; maxX = 0; minY = -1400; maxY = -1300;
                break;

            case 6:
                minX = 0; maxX = 0; minY = -2000; maxY = -1900;
                break;

            case 7:
                minX = 0; maxX = 0; minY = -2300; maxY = -2200;
                break;




            case 11:
                minX = 0; maxX = 0; minY = 0; maxY = 200;
                break;
            case 12:
                minX = 0; maxX = 0; minY = 1400; maxY = 1700;
                break;

            case 13:
                minX = 0; maxX = 0; minY = 2400; maxY = 2600;
                break;

            case 14:
                minX = 0; maxX = 0; minY = 3300; maxY = 3400;
                break;

            case 15:
                minX = 0; maxX = 0; minY = -1400; maxY = -1100;
                break;

            case 16:
                minX = 0; maxX = 0; minY = -1600; maxY = -1300;
                break;

            case 17:
                minX = 0; maxX = 0; minY = -1900; maxY = -1600;
                break;
            // Add cases for other popup groups as needed
            default:
                break;
        }

        Vector3 panelPosition = innerpanel.transform.position;

        // Add or subtract a random value from 0 to 100 to adjust the positions
        float randomOffsetX = Random.Range(0f, 130f);
        float randomOffsetY = Random.Range(0f, 100f);
        minX += panelPosition.x + randomOffsetX;
        maxX += panelPosition.x - randomOffsetX;
        minY += panelPosition.y + randomOffsetY;
        maxY += panelPosition.y - randomOffsetY;

        // Convert random coordinates back to world coordinates
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f);

        return randomPosition;
    }

    string[] GetPopupGroup()
    {
        // Retrieve the popup group based on the specified index
        switch (popupGroupIndex)
        {
            case 1:
                return arrayLibrary.Rumor1_textsArray;
            case 2:
                return arrayLibrary.Rumor2_textsArray;
            case 3:
                return arrayLibrary.Rumor3_textsArray;
            case 4:
                return arrayLibrary.Rumor4_textsArray;
            case 5:
                return arrayLibrary.Rumor5_textsArray;
            case 6:
                return arrayLibrary.Rumor6_textsArray;
            case 7:
                return arrayLibrary.Rumor7_textsArray;



            case 11:
                return arrayLibrary.InsideChatter1_textsArray;
            case 12:
                return arrayLibrary.InsideChatter2_textsArray;
            case 13:
                return arrayLibrary.InsideChatter3_textsArray;
            case 14:
                return arrayLibrary.InsideChatter4_textsArray;
            case 15:
                return arrayLibrary.InsideChatter5_textsArray;
            case 16:
                return arrayLibrary.InsideChatter6_textsArray;
            case 17:
                return arrayLibrary.InsideChatter7_textsArray;
            // Add cases for other popup groups as needed
            default:
                return arrayLibrary.Rumor1_textsArray; // Default to the first popup group
        }
    }
}
