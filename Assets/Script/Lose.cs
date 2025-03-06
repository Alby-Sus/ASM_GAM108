using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverCanvas : MonoBehaviour
{
    public Button retryButton;
    public Button exitButton;

    void Start()
    {
        if (exitButton != null)
            exitButton.onClick.AddListener(ExitToMainMenu);
        if (retryButton != null)
            retryButton.onClick.AddListener(RestartLevel);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void ExitToMainMenu()
    {
        SceneManager.LoadScene("Menu");  // Quay về màn hình chính
    }
}
