using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class AddUserName : MonoBehaviour
{

    //[SerializeField] private TMP_Text userNameOutput;
    [SerializeField] private TMP_InputField userNameInput;

    private string userName;

    private string filePath = "Assets/TxtFiles/AddUserName.txt";

    public void SaveToFile()
    {
        Debug.Log($"username: {userNameInput.text}");
        userName = userNameInput.text;
        File.WriteAllText(filePath, userName);
        Debug.Log($"written to file");
        Debug.Log(File.ReadAllText(filePath));
    }

}
