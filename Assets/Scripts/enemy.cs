using UnityEngine;

public class EnemyFollowPlayer1 : MonoBehaviour
{
    public Transform player;            // Reference to the player's position
    public float speed = 2f;            // Speed at which the enemy moves towards the player
    public bool isPlayerInRange = false; // Flag to check if the player is within range
    private Vector3 startPosition;      // Enemy's initial position

    private void Start()
    {
        // Store the enemy's initial position
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger area

        isPlayerInRange = true;

    }

    private void OnTriggerExit(Collider other)
    {

        isPlayerInRange = false;

    }

    private void Update()
    {
        // If the player is in range, move the enemy towards the player
        if (isPlayerInRange)
        {
            Vector3 direction = (player.position - transform.position).normalized;

            // Set the Y component to 0 to move only horizontally
            direction.y = 0;

            // Move the enemy towards the player
            transform.position += direction * speed * Time.deltaTime;

            // Rotate the enemy to face the player (only on the Y axis), and adjust by 180 degrees
            Quaternion targetRotation = Quaternion.LookRotation(-direction);  // Invert direction to face forward
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speed);
        }
        else
        {
            // When the player is not in range, stop the enemy's movement (or return to start position if needed)
            transform.position = transform.position; // Enemy stops when the player exits the trigger.
        }
    }
}
