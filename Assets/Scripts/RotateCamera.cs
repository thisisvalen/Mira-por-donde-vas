using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;

    void Start()
    {
        // No se requiere inicialización en Start por ahora
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        // Rota la cámara horizontalmente alrededor de su propio eje Y
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * rotationSpeed);
    }
}