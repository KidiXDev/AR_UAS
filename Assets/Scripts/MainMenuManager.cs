using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject FirstMenu, SecondMenu;
    public void OnPlayPressed()
    {
        FirstMenu.SetActive(false);
        SecondMenu.SetActive(true);
    }

    public void OnBackPressed()
    {
        FirstMenu.SetActive(true);
        SecondMenu.SetActive(false);
    }

    public void BeachMenuPressed()
    {
        SceneManager.LoadScene("koboi");
    }

    public void CityMenuPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void EgyptMenuPressed()
    {
        SceneManager.LoadScene("Desa");
    }

    public void OnMainMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting...");
    }
}
