using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float _force = 230f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Flap();
        }

    }

    void Flap()
    {

        rb.AddForce(Vector2.up * _force);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Obstacle"))
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);

            FindObjectOfType<GameManager>().Play("PlayerDeath");

        }

    }

} //class











































