using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    //public int collectedCoins = 0; // Track the player's collected coins
    //public int requiredCoins = 8; // Coins needed to move to the next level

    // Method to add coins
    public void AddCoin()
    {
        //collectedCoins++;
        //Debug.Log($"Coins Collected: {collectedCoins}");
        //Debug.Log($"Coins Required: {requiredCoins}");
        //Debug.Log($"all coins collected: {collectedCoins >= requiredCoins}");
        //// Check if the player has enough coins to move to the next level
        //if (collectedCoins >= requiredCoins)
        //{
        //    Debug.Log("activated");
        //    MoveToNextLevel();
        //}
    }

    // Method to move to the next level
    //public void MoveToNextLevel()
    //{
    //    Debug.Log("Level Completed! Moving to Level 2...");
    //    SceneManager.LoadScene("Level-2");
    //}

    private void Update()
    {
        //AddCoin();
    }
}

    
    //public void RestartLevel()
    //{
    //    SceneManager.LoadScene("SampleScene");
    //}
    //public void LoadNextLevel()
    //{
    //    SceneManager.LoadScene("Level-2");
    //}
    //public void LoadMainMenu()
    //{
    //    SceneManager.LoadScene("MainMenu");
    //}




   