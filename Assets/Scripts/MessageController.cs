using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessageController : MonoBehaviour
{
    [SerializeField] public TMP_Text messageText;
    public float messageDuration = 3.0f;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        // Show the message at the start
        messageText.text = "Use arrow or WASD keys to move.";
        timer = messageDuration;
    }

    // Update is called once per frame
    void Update()
    {
        // Countdown the timer
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            // Hide the message after the duration
            messageText.text = "";
        }
    }
}

