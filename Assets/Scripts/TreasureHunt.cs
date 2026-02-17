using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TreasureHunt : MonoBehaviour
{
    // public variable linked to the reload display
    public GameObject ReloadPanel;
    // 'stepsTaken' is the number of steps taken
    private int _stepsTaken = 0;
    // 'isDead' to track whether the player is or is not alive
    private bool _isDead;

    // TODO:
    // Declare the following variables:
    // 'distanceToTreasure' to store how close the player is to the treasure (in meters)
    // 'hasKey' to track whether the player has found the key
    // 'foundTreasure' to track whether the player has found the treasure chest
    // 'clue' to hold the current hint message


    private void Start()
    {
        // TODO:
        // Initialize your values
        // 'distanceToTreasure' to 15.5f
        // Write an if statement that checks if 'hasKey' is false
        // if it is false, then set 'hasKey' to true
    }

    private void Update()
    {
        if (!_isDead)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Dig();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                UseKey();
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                StepForward();
            }
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Coroutine reloadCoroutine = StartCoroutine(Reload());
        }
    }

    private IEnumerator Reload()
    {
        ReloadPanel.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        ReloadPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }

    // PRIVATE FUNCTIONS
    private void Dig()
    {
        // TODO:
        // Write an if statement that checks if the distance to the treasure is less than 1.5f
        // if true, print "You found the treasure!" to the console and set 'foundTreasure' to TRUE
        // Otherwise, print "Alas, no treasure be found here!" to the console
    }

    private void UseKey()
    {
        // TODO:
        // Write an if statement that checks if the player has the key and has found the treasure
        // if both true, print "You've unlocked the treasure!  The booty be yers!" to the console
        // Otherwise, print "There be nothing to unlock!" to the console
    }

    private void StepForward()
    {
        _stepsTaken++;
        
        // TODO:
        // Call CalculateDistanceToTreasure();
        
        DisplayClue();
    }

    /*private float CalculateDistanceToTreasure()
    {
        // TODO:
        // Set the 'distanceToTreasure' to equal 'distanceToTreasure' minus 'stepsTaken'
        // return 'distanceToTreasure'
    }*/

    private void DisplayClue()
    {
        // TODO:
        // Write an if statement that checks if the 'distanceToTreasure' is greater than 15.5f or is less than 0.0f
        // if true, set 'wrongWay' to True and clue equal to "Aye! Ye be going the wrong way!"
        // Write an else if statement that checks if the 'distanceToTreasure' is less than 15.5f and greater than or equal to 10.5f
        // if true, set clue equal to "I sense ye be getting closer"
        // Write an else if statement that checks if the 'distanceToTreasure' is less than 10.5f and greater than or equal to 5.5f
        // if true, set clue equal to "Aye, not too far now"
        // Write an else if statement that checks if the 'distanceToTreasure' is less than 5.5f and greater than or equal to 1.5f
        // if true, set clue equal to "Almost there!  I can smell it!"
        // Otherwise, set clue equal to "Dig here! Dig here! We be at the spot on the map!"
        // Debug.Log('clue') to the console
    }
}