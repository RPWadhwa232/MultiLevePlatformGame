using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;
public class UpdateUsernameCanvas : MonoBehaviour
{

    [SerializeField] private TMP_Text username;
    private string filePath = "Assets/TxtFiles/AddUserName.txt";
    private string usernameFromFile;

    // Start is called before the first frame update
    void Start()
    {
        usernameFromFile = File.ReadAllText(filePath);
        username.text = usernameFromFile;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
