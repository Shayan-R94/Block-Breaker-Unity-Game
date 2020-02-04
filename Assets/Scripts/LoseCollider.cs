using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour
{

    private LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        levelManager = FindObjectOfType<LevelManager>();
        GameControl.health -= 1;

        if (GameControl.health > 0)
        {
            Ball.hasStarted = false;
        }

        if (GameControl.health <= 0)
        {
            levelManager.LoadLevel("Lose");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
}
