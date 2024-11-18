using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddUserName : MonoBehaviour
{
    [SerializeField] private TMP_Text userNameOutput;
    [SerializeField] private TMP_InputField userNameInput;

    private string userName;

    private string filePath = "Assets/TxtFiles/UserName.txt";

    // Removed the constructor as MonoBehaviour classes should not have constructors
    // Use Awake or Start for initialization instead

    
    {
        
        userName = "RP";
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddName()
    {
        userName = userNameInput.text;
        userNameOutput.text = userName;
        SaveUserNameToFile(userName);
    }

   private void SaveUserNameToFile(string name)
    {
        // Ensure the directory exists
        string directoryPath = Path.GetDirectoryName(filePath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Write the name to the file
        File.WriteAllText(filePath, name);
    }

    private void LoadUserNameFromFile()
    {
        if (File.Exists(filePath))
        {
            userName = File.ReadAllText(filePath);
            userNameOutput.text = userName;
        }
        else
        {
            Debug.LogWarning("UserName file not found");
        }
    }
}
