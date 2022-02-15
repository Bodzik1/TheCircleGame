using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject gameOver;

    public float _force = 230f;

    private Rigidbody2D rb;

    public int health = 1;

    // Start is called before the first frame update
    void Awake()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if(health <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            Destroy(gameObject);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Flap();
        }

    }

    void Flap()
    {

        rb.AddForce(Vector2.up * _force);

    }

} //class











































