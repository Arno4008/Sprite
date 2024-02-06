using InfimaGames.LowPolyShooterPack;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public Character c;
    public void resume()
    {
        c.cursorLocked = true;
        foreach (GameObject go in c.m.gm)
        {
            go.SetActive(true);
        }
    }
}
