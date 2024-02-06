using EmeraldAI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameManager m;
    public Player p;
    public int money_gain;
    public int gems_gain;
    public float xp_gain;
    public int LuckToLootGems;
    public BoxCollider AiCollider1, AiCollider2;
    private void Start()
    {
        AiCollider1.enabled = true;
        AiCollider2.enabled = true;
    }
    public void DeathEnemy()
    {
        m.EnemyKillCompt++;
        m.money += money_gain;
        p.xp += xp_gain;
        if (Random.Range(1, 100) >= LuckToLootGems)
        {
            m.gems += gems_gain;
        }
        m.GetComponent<Save>().save();
        m.GetComponent<UIManager>().UpdateUI();
    }
    public void Heal()
    {
        Debug.Log("Enemy Heal");
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            if (Random.Range(1, 100) <= p.LuckCriticalHit)
            {
                p.randomBool = true;
            }
            else
            {
                p.randomBool = false;
            }
            if (p.randomBool)
            {
                GetComponent<EmeraldAISystem>().Damage(p.DamageCritic, null, p.transform, 100, p.randomBool);
            }
            if (!p.randomBool)
            {
                GetComponent<EmeraldAISystem>().Damage(p.Damage, null, p.transform, 100, p.randomBool);
            }
        }
    }*/
}
