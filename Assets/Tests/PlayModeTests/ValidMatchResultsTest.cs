using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ValidMatchResultsTest
{
    /// <summary>
    /// This test is to catch the AI inputting "Nothing"
    /// as its selection in a game of rock paper scissors.
    /// 
    /// The intention is that this test will run until it detects that the player or the enemy 
    /// manages to get the game to spit out text other than the expected results.
    /// 
    /// If I had some more time, I would make it loop through all the gameobjects with buttons,
    /// add them to an array, and press them all at random, so that if the game is changed down
    /// the line, the other buttons can be checked to see if they break the game as well.
    /// 
    /// This test has a chance of succeeding due to random chance, but the probability is very low.
    /// Given that the error itself manifests as a hard coded random range, I think this is an 
    /// adequate way to catch the error.
    /// </summary>
    public int numOfSimulatedMatches = 10000;
    [UnityTest]
    public IEnumerator ValidOptionsFromPlayers()
    {
        
        //First, load the game scene.
        SceneManager.LoadScene("BRPS");
        //Wait for it to be loaded.
        yield return null;

        //instantiate a list of all the buttons that the player is able to press to play the game.
        Button[] buttonObjects;
        buttonObjects = new Button[3];
        buttonObjects[0] = GameObject.Find("Rock Button").GetComponent<Button>();
        buttonObjects[1] = GameObject.Find("Paper Button").GetComponent<Button>();
        buttonObjects[2] = GameObject.Find("Scissors Button").GetComponent<Button>();

        //Instantiate a variable to track the text output by the game's match system.
        Text playerText = GameObject.Find("Player Hand").GetComponent<Text>();
        Text enemyText = GameObject.Find("Enemy Hand").GetComponent<Text>();


        for (int i = 0; i < numOfSimulatedMatches; i++){
            //Press one of the three buttons randomly.
            buttonObjects[Random.Range(0, 2)].onClick.Invoke();
            yield return new WaitForEndOfFrame();

            //If the player hand text reads as anything other than Rock, Paper, or Scissors, then fail the test.
            if(!(playerText.text == "Rock" || playerText.text == "Paper" || playerText.text == "Scissors"))
            {
                Assert.Fail("Player selection is: " + playerText.text + ". Error happened on simulated match # " + i);
            }
            //If the enemy hand text reads as anything other than Rock, Paper, or Scissors, then fail the test.
            if (!(enemyText.text == "Rock" || enemyText.text == "Paper" || enemyText.text == "Scissors"))
            {
                Assert.Fail("Enemy selection is: " + enemyText.text + ". Error happened on simulated match # " + i);
            }
        }
        //If we've ran through the number of tests without any match generating invalid results, pass the test.
        Assert.Pass("Player and Enemy made no invalid results after " + numOfSimulatedMatches + " simulated matches.");
    }
}
