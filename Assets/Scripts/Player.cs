using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager m;
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
    public bool randomBool;
    private float jumpForce = 7f;
    private float fallMultiplier = 2.5f;
    private float lowJumpMultiplier = 2f;
    private int jumpCount;
    public int maxJump;
    private Rigidbody rb;
    public bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Random.Range(1, 100) <= LuckCriticalHit)
            {
                randomBool = true;
            } else
            {
                randomBool = false;
            }
        }
        if (Input.GetButtonDown("Jump") && (isGrounded || jumpCount < maxJump))
        {
            rb.velocity = Vector3.up * jumpForce;
            isGrounded = false;
            jumpCount++;
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}