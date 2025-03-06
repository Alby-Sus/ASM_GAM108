using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{
    public Button nextLevelButton;
    public string SampleScene; // Tên màn tiếp theo, có thể chỉnh trong Inspector
    public Button exitButton;

    void Start()
    {
        if (nextLevelButton != null)
            nextLevelButton.onClick.AddListener(NextLevel);

        if (exitButton != null)
            exitButton.onClick.AddListener(ExitToMainMenu);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SampleScene);  // Chuyển đến màn được chỉ định
    }
    void ExitToMainMenu()
    {
        SceneManager.LoadScene("Menu");  // Quay về màn hình chính
    }
}
