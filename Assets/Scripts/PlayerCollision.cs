using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision object is tagged as "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        // Load the "GameOver" scene
        SceneManager.LoadScene("GameOver");
    }
}
