using EmeraldAI.Example;
using TMPro;
using UnityEngine;

public class GameManagerMainMenu : MonoBehaviour
{
    [Header("Stats du joueur:")]
    [Tooltip("Damage du player (PV)")]
    public float Damage;
    [Tooltip("Levels du player")]
    public int levels;
    [Tooltip("Damage du player en coup critique (PV)")]
    public int DamageCritic;
    [Tooltip("% de chance de faire un coup critique (%)")]
    public int LuckCriticalHit;
    public float xp;
    public int maxJump;
    public long money;
    public int gems;
    public int health;
    private const string format = "{0}";
    public TMP_Text TextHealth;
    public TMP_Text LvlTXT;
    public TMP_Text CoinsTXT;
    public TMP_Text GemsTXT;
    void Awake()
    {
        LoadGame();
    }
    public void save()
    {
        SaveSc s = new SaveSc();
        s.levels = levels;
        s.xp = xp;
        s.damage = Damage;
        s.health = health;
        s.money = money;
        s.gems = gems;
        s.LuckCriticalHit = LuckCriticalHit;
        string json = JsonUtility.ToJson(s, true);
        System.IO.File.WriteAllText(Application.dataPath + "/savefile.json", json);
        Debug.Log("Saved");
    }
    public void LoadGame()
    {
        if (System.IO.File.Exists(Application.dataPath + "/savefile.json"))
        {
            string json = System.IO.File.ReadAllText(Application.dataPath + "/savefile.json");
            SaveSc s = JsonUtility.FromJson<SaveSc>(json);

            levels = s.levels;
            Damage = s.damage;
            LuckCriticalHit = s.LuckCriticalHit;
            xp = s.xp;
            health = s.health;
            money = s.money;
            gems = s.gems;
        }
        else
        {
            Debug.Log("No save file found");
        }
    }
    public class SaveSc
    {
        public string[] name;
        public int levels;
        public int LuckCriticalHit;
        public long money;
        public float damage;
        public float xp;
        public int health;
        public int gems;
    }
    public void UpdateUI()
    {
        TextHealth.text = string.Format(format, health);
        LvlTXT.text = string.Format(format, GetComponent<Player>().levels);
        CoinsTXT.text = string.Format(format, money);
        GemsTXT.text = string.Format(format, gems);
    }
}
