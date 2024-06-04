using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/***
 * English:
"In Toronto, there are more Spanish-speaking people now. Over time, the number of Spanish speakers has gone up. Recent estimates say there are about 100,000 Spanish speakers in Toronto."

Spanish:
"En Toronto, ahora hay más personas que hablan español. Con el tiempo, el número de hablantes de español ha aumentado. Según estimaciones recientes, hay alrededor de 100,000 personas que hablan español en Toronto."





English:
"In Florida, there are many Spanish-speaking people. They have been there for a long time, and they bring their culture with them. Places like Miami have neighborhoods where you can feel like you're in Spain. People speak Spanish in many places, making Florida a friendly place for Spanish speakers."

Spanish:
"En Florida, hay muchas personas que hablan español. Han estado allí durante mucho tiempo y traen su cultura con ellos. Lugares como Miami tienen vecindarios donde puedes sentirte como en España. La gente habla español en muchos lugares, lo que hace de Florida un lugar amigable para los hispanohablantes."




English:
"In Brazil, there are Spanish-speaking people. They come from different countries in Latin America. Some come to work, while others come to live with their families. They bring their language and culture with them."

Spanish:
"En Brasil, hay personas que hablan español. Vienen de diferentes países de América Latina. Algunos vienen a trabajar, mientras que otros vienen a vivir con sus familias. Traen su idioma y cultura con ellos."


 */





public class WorldManager : MonoBehaviour
{
    public SaveManager saveManager;
    public GameManager gameManager;
    public DetectImage detectImage;


    public RectTransform map; // Assign your map's RectTransform
    public Transform[] targets; // Assign the empty GameObjects placed at points of interest on your map
    private Transform currentTarget;
    public float scrollSpeed = 1.0f; // Adjust scrolling speed as needed


    void Start()
    {
        
    }

    void Update()
    {
        if (currentTarget != null)
        {
            // Calculate the step size based on speed and frame rate
            float step = scrollSpeed * Time.deltaTime;
            // Move the map's position towards the current target position
            map.position = Vector3.MoveTowards(map.position, currentTarget.position, step);
        }
    }

    // Call this method to set the new target and start scrolling towards it
    public void ScrollToTarget(int targetIndex)
    {
        if (targetIndex >= 0 && targetIndex < targets.Length)
        {
            currentTarget = targets[targetIndex];
        }
    }











    public void buyFlag()     ////factCardboolean[i] in saveManager
    {
        PlayerData playerData = saveManager.GetPlayerData();

        if (playerData.scrapAmount >= ((playerData.flagLevel+1) * 50))
        {

            for (int i = 1; i <= 100; i++)
            {
                string tag = "PassThrough" + i;
                if (detectImage.tagToDetect == tag && playerData.factCardboolean[i - 1] == 0)
                {
                    playerData.factCardboolean[i - 1] = 1;
                    playerData.flagLevel++;
                    playerData.scrapAmount = playerData.scrapAmount - ((playerData.starLevel + 1) * 50);
                    detectImage.brainpowerAndCostText.text = "Brainpower: " + playerData.scrapAmount + " \nCost: " + (playerData.flagLevel + 1) * 50;
                    detectImage.flaglevelText.text = "Star: \n" + playerData.flagLevel.ToString();

                    detectImage.announcerText.text = detectImage.arrayLibrary.WORLD_textsArray[i - 1];
                    detectImage.buyButtonToggle.SetActive(false);
                    //turn off the buy button
                    saveManager.SavePlayerData();
                }
                else { }
            }





            /*

                        if (optionIndex == correctAnswers[0]) // Check the answer for the first question only
                        {
                            Debug.Log("Correct!");
                            // Handle correct answer logic here
                            correctorIncorrectText.text = "Correct! \n(wait for reset)";
                            detectImageQuiz.AButtonToggle.SetActive(false);
                            detectImageQuiz.BButtonToggle.SetActive(false);
                            detectImageQuiz.CButtonToggle.SetActive(false);
                            detectImageQuiz.DButtonToggle.SetActive(false);


                            playerData.starLevel++;
                            playerData.scrapAmount = playerData.scrapAmount - ((playerData.starLevel + 1) * 10);
                            detectImageQuiz.brainpowerAndCostText.text = "Brainpower: " + playerData.scrapAmount + " \nCost: " + (playerData.starLevel + 1) * 10;
                            detectImageQuiz.starlevelText.text = "Star: \n" + playerData.starLevel.ToString();


                            for (int i = 0; i < detectImageQuiz.interestedTags.Length; i++)
                            {
                                // Check if the current tag matches the one to detect
                                if (detectImageQuiz.tagToDetect == detectImageQuiz.interestedTags[i])
                                {
                                    // Set the corresponding cooldown value
                                    star_cooldownValues[i] = "NotReady";
                                    // Exit the loop since the match is found
                                    break;
                                }
                            }




                        }
                        else
                        {
                            Debug.Log("Incorrect!");
                            correctorIncorrectText.text = "Incorrect! \n(wait for reset)";
                            detectImageQuiz.AButtonToggle.SetActive(false);
                            detectImageQuiz.BButtonToggle.SetActive(false);
                            detectImageQuiz.CButtonToggle.SetActive(false);
                            detectImageQuiz.DButtonToggle.SetActive(false);

                            star_cooldownValues[0] = "NotReady";


                            playerData.scrapAmount = playerData.scrapAmount - ((playerData.starLevel + 1) * 10);
                            detectImageQuiz.brainpowerAndCostText.text = "Brainpower: " + playerData.scrapAmount + " \nCost: " + (playerData.starLevel + 1) * 10;

                            // Handle incorrect answer logic here
                            for (int i = 0; i < detectImageQuiz.interestedTags.Length; i++)
                            {
                                // Check if the current tag matches the one to detect
                                if (detectImageQuiz.tagToDetect == detectImageQuiz.interestedTags[i])
                                {
                                    // Set the corresponding cooldown value
                                    star_cooldownValues[i] = "NotReady";
                                    // Exit the loop since the match is found
                                    break;
                                }
                            }


                        }



                    }

                    else { gameManager.ToggleVisibility(); }

            */

        }
        else { gameManager.ToggleVisibility(); }
    }







}
