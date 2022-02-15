using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public int damage = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().health -= damage;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Obstacle"))
        {

            other.gameObject.SetActive(false);

            ObstacleGenerator.Obstacles.Enqueue(other.gameObject);

        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}

