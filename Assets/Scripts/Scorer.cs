using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    public int totalhits = 8;

    void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }


    }
    public void ObjectHit()
    {
        hits++;
        if (hits >= totalhits)
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene("Level-2");
    }


}
