using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;
//using UnityEditor;

public class OnClickButton : MonoBehaviour
{
    private Dictionary<string, System.Action> buttonActions;

    public OnClickButton(Dictionary<string, Action> buttonActions)
    {
        this.buttonActions = buttonActions;
    }

    // Start is called before the first frame update
    void Start()
    {
        // added this line to unlock the cursor
        Cursor.lockState = CursorLockMode.None;

        // Initialize the dictionary with button names and their corresponding actions
        buttonActions = new Dictionary<string, System.Action>
        {
            { "PlayButton", PlayGame },
            { "ExitButton", ExitGame },
            { "SettingsButton", OpenSettings },
            { "GoBackButton", GoBack },
            { "SelectLevelButton", SelectLevel },
            { "RestartButton", RestartGame }
        };
    }

    public void OnButtonClick()
    {
        // Get the name of button clicked
        string buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        // Check if the button name exists in the dictionary and invoke the corresponding action
        if (buttonActions.TryGetValue(buttonName, out System.Action action))
        {
            action.Invoke();
        }
        else
        {
            Debug.Log("Invalid Button Clicked");
        }
    }

    private void PlayGame()
    {
        Debug.Log("Play Button Clicked");
        SceneManager.LoadScene("GameScene");
    }

    private void ExitGame()
    {
        Debug.Log("Exit Button Clicked");
        Application.Quit();
        // for editor
        ////UnityEditor.EditorApplication.isPlaying = false
    }

    private void OpenSettings()
    {
        Debug.Log("Settings Button Clicked");
        SceneManager.LoadScene("SettingsMenu");
    }

    private void GoBack()
    {
        Debug.Log("Back Button Clicked");
        SceneManager.LoadScene("MainMenu");
    }

    private void SelectLevel()
    {
        SceneManager.LoadScene("Level-2");
    }

    private void RestartGame()
    {
        Debug.Log("Restart Button Clicked");
        string SampleScene = System.IO.File.ReadAllText("Assets/TxtFiles/AddUserName.txt");
        SceneManager.LoadScene(SampleScene);
    }
}

    //public void OnButtonClick()
    //{
    //    // Get the name of button clicked
    //    string buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
    //    if (buttonName == "PlayButton")
    //    {
    //        Debug.Log("Play Button Clicked");
    //        // Load the first level
    //        SceneManager.LoadScene("GameScene");
    //    }
    //    else if (buttonName == "ExitButton")
    //    {
    //        Debug.Log("Exit Button Clicked");
    //        // Exit the game
    //        Application.Quit();
    //        // for editor
    //        UnityEditor.EditorApplication.isPlaying = false;
    //    }
    //    else if (buttonName == "SettingsButton")
    //    {
    //        Debug.Log("Settings Button Clicked");
    //        SceneManager.LoadScene("SettingsMenu");
    //    }
    //    else if (buttonName == "GoBackButton")
    //    {
    //        Debug.Log("Back Button Clicked");
    //        SceneManager.LoadScene("MainMenu");
    //    }
    //    else if (buttonName == "SelectLevelButton")
    //    {
    //        SceneManager.LoadScene("Level-2");
    //    }
    //    else if (buttonName == "RestartButton")
    //    {
    //        Debug.Log("Restart Button Clicked");
    //        string lastScene = System.IO.File.ReadAllText("Assets/TxtFiles/lastScene.txt");
    //    }
    //    else
    //    {
    //        Debug.Log("Invalid Button Clicked");
    //    }
    //}

