using EmeraldAI;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject[] UIText;
    public GameObject[] gm;
    public GameObject PGui;
    public GameObject GuiMGL;
    public int EnemyKillCompt;
    public int EnemyKillMax;
    public int FoundObjects;
    public int FoundObjectsMax;
    public int Select;
    public bool Pause;
    public long money;
    public int gems;
    private Save s;
    private void Awake()
    {
        //s = GetComponent<Save>();
        //s.LoadGame();
    }
    void Start()
    {
        gm = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (GameObject go in gm)
        {
            if(go.GetComponent<EmeraldAISystem>() != null)
            {
                EnemyKillMax++;
            }
        }
        GameObject[] g = GameObject.FindGameObjectsWithTag("Object");
        foreach (GameObject go in g)
        {
            FoundObjectsMax++;
        }
        GetComponent<UIManager>().UpdateUI();
    }
    void Update()
    {
        if (Input.GetButtonDown("tab"))
        {
            GuiMGL.SetActive(true);
        }
        if (Input.GetButtonUp("tab"))
        {
            GuiMGL.SetActive(false);
        }
        if (Select > 0)
        {
            StartCoroutine(AffText());
        }
    }
    public IEnumerator AffText()
    {
        UIText[Select].SetActive(true);
        yield return new WaitForSeconds(2);
        UIText[Select].SetActive(false);
        Select = 0;
    }
}
