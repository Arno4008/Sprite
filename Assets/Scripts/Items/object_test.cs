using UnityEngine;

public class object_test : MonoBehaviour
{
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
            gameObject.SetActive(false);
            other.GetComponent<Player>().Damage += 5;
            other.GetComponent<Player>().DamageCritic += 5;
            m.GetComponent<GameManager>().FoundObjects++;
            m.GetComponent<GameManager>().Select = 1;
            m.GetComponent<UIManager>().UpdateUI();
        }
    }
    void Update()
    {
        tempVal = Mathf.Sin(Time.time * Mathf.PI * frequency) * amplitude;
        transform.position = Vector3.Lerp(transform.position, startPosition + new Vector3(0, tempVal, 0), Time.deltaTime);

        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
