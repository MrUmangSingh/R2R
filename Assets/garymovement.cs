using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 0.2f; // Adjust the speed in the Inspector
    private bool isInRoom = false; // Track whether the player is in the room

    void Update()
    {
        // Check if the player is in the room (you can modify this condition based on your game logic)
        if (isInRoom)
        {
            // Specify a constant direction (e.g., right)
            Vector3 movement = Vector3.left;

            // Move the object in a constant direction
            transform.Translate(movement * speed * Time.deltaTime);
        }
    }

    // Assume you have a method to detect when the player enters or exits the room
    public void SetInRoom(bool value)
    {
        isInRoom = value;
    }
}
