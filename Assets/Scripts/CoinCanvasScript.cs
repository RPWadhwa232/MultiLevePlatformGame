using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CoinCanvasScript : MonoBehaviour
{
    private int collectedCoins = 0;
    [SerializeField] public TMP_Text coinCounter;
    // Start is called before the first frame update
        
    public int requiredCoins = 8;


    void Start()
    {
        
        coinCounter.text = $"score: {collectedCoins}";

    }

    public void MoveToNextLevel()
    {
        Debug.Log("Level Completed! Moving to Level 2...");
        SceneManager.LoadScene("Level-2");
    }

    public void AddScore()
    {

        Debug.Log("Coin collected");
        collectedCoins++;
        coinCounter.text = $"score: {collectedCoins}";

        Debug.Log($"Coins Collected: {collectedCoins}");
        Debug.Log($"Coins Required: {requiredCoins}");
        Debug.Log($"all coins collected: {collectedCoins >= requiredCoins}");
        // Check if the player has enough coins to move to the next level
        if (collectedCoins >= requiredCoins)
        {
            Debug.Log("activated");
            MoveToNextLevel();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // coinCounter.SetText(collectedCoins.ToString());
    }
}
