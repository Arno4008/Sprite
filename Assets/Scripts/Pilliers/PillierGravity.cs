using UnityEngine;

public class PillierGravity : MonoBehaviour
{
    public Vector3 lunarGravity = new Vector3(0, -1.635f, 0);

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody != null && other.CompareTag("Player"))
        {
             other.attachedRigidbody.useGravity = false;
            other.attachedRigidbody.velocity += lunarGravity * Time.fixedDeltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.attachedRigidbody != null && other.CompareTag("Player"))
        {
            other.attachedRigidbody.useGravity = true;
        }
    }
}
