using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrayMove : MonoBehaviour
{
     public float speed = 0.2f;
     public float radius = 0.5f;
    public float distance = 1.0f;
    public bool isinside = false;
    void OntriggerEnter(Collider other)
    {
            isinside = true;
            Debug.Log("Triggered");
    }

    

    void FixedUpdate()
    {
        if (isinside)
            {
                // Handle player interaction
                // Debug.Log("Hit player: " + hitCollider.name);

                StartMoving();
                Debug.Log("In move fn");

            }

    }
     void StartMoving()
    {
        // Specify a constant direction (e.g., right)
        Vector3 movement = Vector3.left;

        // Move the object in a constant direction
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
