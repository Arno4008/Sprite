using EmeraldAI;
using UnityEngine;

public class Pojectile : MonoBehaviour
{
    public Player p;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Respawn") && other != null)
        {
            if (p.randomBool)
            {
                other.GetComponent<EmeraldAISystem>().Damage(p.DamageCritic, null, transform, 100, true);
            }
            if (!p.randomBool)
            {
                other.GetComponent<EmeraldAISystem>().Damage(p.Damage, null, transform, 100, false);
            }
        }
    }
}