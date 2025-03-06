using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button tutorialButton;
    public Button exitButton;

    void Start()
    {
        // Gán sự kiện OnClick cho các nút
        startButton.onClick.AddListener(StartGame);
        tutorialButton.onClick.AddListener(OpenTutorial);
        exitButton.onClick.AddListener(ExitGame);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenTutorial()
    {
        SceneManager.LoadScene("TutorialScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
