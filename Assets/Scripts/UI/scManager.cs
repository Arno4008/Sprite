using UnityEngine;
using UnityEngine.SceneManagement;

public class scManager : MonoBehaviour
{
    public GameObject LoadObj;
    public GameObject MainMenu;
    public GameObject Shop;
    public GameObject Settings;
    public void GoInGame()
    {
        Shop.SetActive(false);
        Settings.SetActive(false);
        MainMenu.SetActive(false);
        LoadObj.SetActive(true);
        SceneManager.LoadScene("MainScene");
    }
    public void GoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
