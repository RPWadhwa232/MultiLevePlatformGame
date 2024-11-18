using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 50;
    [SerializeField] TMP_Text textBox;


    public void setHealth(int health)
    {
        this.health = health;
        textBox.text = getHealth();
    }
    public string getHealth()
    {
        this.health = health;
        return this.health + " is my health run ";
    }
}
