using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb; // Corregido a Rigidbody 3D
    private GameObject player;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>(); // Corregido a Rigidbody 3D
        player = GameObject.Find("Player");
    }

    void Update()
    {
        // Protegemos la lógica por si el jugador es destruido o no se encuentra en escena
        if (player != null)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }

        // Si el enemigo se cae de la isla, se destruye
        if (transform.position.y < -10) 
        { 
            Destroy(gameObject); 
        }
    }
}