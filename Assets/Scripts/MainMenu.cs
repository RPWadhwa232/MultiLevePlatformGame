using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEditor;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private readonly Button settingButton;
    //private readonly SettingsUI settingsMenu;

    public void CheckWhichButtonClick()
    {

    }

    // Start is called before the first frame update
    public void StartGame()
    {
        Debug.Log("Run the game");
        SceneManager.LoadScene("SampleScene");
    }
    public void SelectLevel()
    {
        Debug.Log("Select Level");
        SceneManager.LoadScene("Level-2");
    }
    public void QuitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
    public void Settings()
    {
        Debug.Log("Enter Player Name");
        SceneManager.LoadScene("PlayerNameScene");
    }

}
