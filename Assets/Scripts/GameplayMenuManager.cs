using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayMenuManager : MonoBehaviour
{
    public void OnBackButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
