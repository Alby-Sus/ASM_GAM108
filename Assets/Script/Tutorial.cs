using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialMenu : MonoBehaviour
{
    public Button backButton;

    void Start()
    {
        backButton.onClick.AddListener(BackToMenu);
    }

    public void BackToMenu()
    {
        // Quay lại Menu chính
        SceneManager.LoadScene("Menu");
    }
}
