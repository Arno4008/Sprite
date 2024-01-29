using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float x;

    void Update()
    {
        // Obtenez l'angle de rotation pour l'axe X en fonction du temps.
        float rotationAngle = Time.deltaTime * rotationSpeed;

        // Appliquer la rotation à la Directional Light autour de l'axe X.
        transform.Rotate(rotationAngle, 0, 0);
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("ici");
            rotationSpeed += x;
        }
    }
}
