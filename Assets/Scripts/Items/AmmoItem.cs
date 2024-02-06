using InfimaGames.LowPolyShooterPack;
using UnityEngine;

public class AmmoItem : MonoBehaviour
{
    public Magazine Weapon1, Weapon2;
    public GameObject m;
    public GameObject UIFalse;
    public GameObject UITrue;
    private float amplitude = 0.5f;
    private float frequency = 1f;
    private Vector3 rotationSpeed = new Vector3(0, 50, 0);
    private Vector3 startPosition;
    private float tempVal;
    void Start()
    {
        startPosition = transform.position;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            UIFalse.SetActive(false);
            UITrue.SetActive(true);
            m.GetComponent<GameManager>().FoundObjects++;
            m.GetComponent<UIManager>().UpdateUI();
            m.GetComponent<GameManager>().Select = 2;
            Weapon1.ammunitionTotal += 10;
            Weapon2.ammunitionTotal += 10;
            gameObject.SetActive(false);
        }
    }
    void Update()
    {
        tempVal = Mathf.Sin(Time.time * Mathf.PI * frequency) * amplitude;
        transform.position = Vector3.Lerp(transform.position, startPosition + new Vector3(0, tempVal, 0), Time.deltaTime);

        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
