using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float patrolSpeed = 2f;
    public Transform pointA, pointB;
    private bool movingToPointB = true;

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        Transform target = movingToPointB ? pointB : pointA;
        Vector3 vector3 = Vector3.MoveTowards(transform.position, target.position, patrolSpeed * Time.deltaTime);
        transform.position = vector3;

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            movingToPointB = !movingToPointB;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Deal damage to the player
            Debug.Log("Player hit by enemy!");
        }
    }
}
