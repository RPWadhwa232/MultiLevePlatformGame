using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    //[SerializeField] GameObject coinCanvas;
    private CoinCanvasScript coinCanvasScript;

    public float rotateSpeed = 100f;

    void Start()
    {
        // Find the CoinCanvasScript in the scene
        coinCanvasScript = FindObjectOfType<CoinCanvasScript>();
        if (coinCanvasScript == null)
        {
            Debug.Log("CoinCanvasScript not found in the scene.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if player collides with the coin
        {
            coinCanvasScript.AddScore(); // Update the score
            Destroy(gameObject); // Remove the coin from the scene
        }
    }
    private void Update()
    {
        // Rotate the coin around the y-axis
        float angle = rotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, angle, Space.World);
    }
}
   
