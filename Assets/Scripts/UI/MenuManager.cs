using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject ShopMenu;
    public GameObject MainMenu;
    public GameObject Settings;
    public void BackToMainMenu()
    {
        if(ShopMenu != null )
        {
            ShopMenu.SetActive(false);
        }
        Settings.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void GoToSettings()
    {
        if (ShopMenu != null)
        {
            ShopMenu.SetActive(false);
        }
        Settings.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void GoToShop()
    {
        if (ShopMenu != null)
        {
            ShopMenu.SetActive(true);
        }
        Settings.SetActive(false);
        MainMenu.SetActive(false);
    }
}
