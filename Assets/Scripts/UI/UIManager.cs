using EmeraldAI.Example;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject p;
    public TMP_Text TextCurrentHealth;
    public TMP_Text TextMaxHealth;
    public TMP_Text LvlTXT;
    public TMP_Text CoinsTXT;
    public TMP_Text GemsTXT;
    public TMP_Text KillEnemies;
    public TMP_Text EnemyKillMax;
    public TMP_Text FoundObjects;
    public TMP_Text FoundObjectsMax;
    private const string format = "{0}";
    void Start()
    {
        TextCurrentHealth.text = string.Format(format, p.GetComponent<EmeraldAIPlayerHealth>().CurrentHealth);
        TextMaxHealth.text = string.Format(format, p.GetComponent<EmeraldAIPlayerHealth>().CurrentHealth);
        KillEnemies.text = string.Format(format, GetComponent<GameManager>().EnemyKillCompt);
        EnemyKillMax.text = string.Format(format, GetComponent<GameManager>().EnemyKillMax);
        FoundObjects.text = string.Format(format, GetComponent<GameManager>().FoundObjects);
        FoundObjectsMax.text = string.Format(format, GetComponent<GameManager>().FoundObjectsMax);
    }
    public void UpdateUI()
    {
        TextCurrentHealth.text = string.Format(format, p.GetComponent<EmeraldAIPlayerHealth>().CurrentHealth);
        KillEnemies.text = string.Format(format, GetComponent<GameManager>().EnemyKillCompt);
        FoundObjects.text = string.Format(format, GetComponent<GameManager>().FoundObjects);
        LvlTXT.text = string.Format(format, p.GetComponent<Player>().levels);
        CoinsTXT.text = string.Format(format, GetComponent<GameManager>().money);
        GemsTXT.text = string.Format(format, GetComponent<GameManager>().gems);
    }
}
