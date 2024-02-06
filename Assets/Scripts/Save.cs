using EmeraldAI.Example;
using UnityEngine;

public class Save : MonoBehaviour
{
    public Player p;
    public GameManager m;
    public void save()
    {
        SaveSc s = new SaveSc();
        s.levels = p.levels;
        s.xp = p.xp;
        s.damage = p.Damage;
        s.health = p.GetComponent<EmeraldAIPlayerHealth>().StartingHealth;
        s.money = m.money;
        s.gems = m.gems;
        s.LuckCriticalHit = p.LuckCriticalHit;
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

            p.levels = s.levels;
            p.Damage = s.damage;
            p.LuckCriticalHit = s.LuckCriticalHit;
            p.xp = s.xp;
            p.GetComponent<EmeraldAIPlayerHealth>().StartingHealth = s.health;
            m.money = s.money;
            m.gems = s.gems;
        }
        else
        {
            Debug.Log("No save file found");
        }
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