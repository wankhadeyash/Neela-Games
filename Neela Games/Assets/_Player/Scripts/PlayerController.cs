using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NeelaGames.AnimalRescue
{
    // This class controls the player's movement and interactions.
    public class PlayerController : MonoBehaviour
    {
        // Reference to the PlayerInput component.
        PlayerInput playerInput;

        // Layer mask to identify background objects.
        public LayerMask backgroundMask;

        // Called when the script instance is being loaded.
        private void Awake()
        {
            // Get the PlayerInput component attached to the game object.
            playerInput = GetComponent<PlayerInput>();
        }

        // Method to handle player movement based on input actions.
        public void Move(InputAction.CallbackContext context)
        {
            // Check if the input action was performed.
            if (context.performed)
            {
                // Log the input value for debugging purposes.
                Debug.Log(context.ReadValue<Vector2>());

                // Read the input vector.
                Vector2 input = context.ReadValue<Vector2>(); // x -> 1, -1  y -> 1, -1

                // Store the current position.
                Vector2 newPos = transform.position;

                // Moving up
                if (input == Vector2.up && !Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), 0.25f, backgroundMask))
                {
                    newPos.y += 1;
                }
                // Moving down
                if (input == Vector2.down && !Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), 0.25f, backgroundMask))
                {
                    newPos.y -= 1;
                }
                // Moving right
                if (input == Vector2.right && !Physics2D.OverlapCircle(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), 0.25f, backgroundMask))
                {
                    newPos.x += 1;
                }
                // Moving left
                if (input == Vector2.left && !Physics2D.OverlapCircle(new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), 0.25f, backgroundMask))
                {
                    newPos.x -= 1;
                }

                // Update the player's position.
                transform.position = newPos;
            }
        }

        // Called when the game object is selected in the Unity editor.
        private void OnDrawGizmosSelected()
        {
            // Draw wire spheres at the positions where movement is checked.
            Gizmos.DrawWireSphere(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), 0.25f);
            Gizmos.DrawWireSphere(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), 0.25f);
            Gizmos.DrawWireSphere(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), 0.25f);
            Gizmos.DrawWireSphere(new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), 0.25f);
        }

        // Called when another collider enters the trigger collider attached to this object.
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // Log the tag and name of the collided object for debugging purposes.
            Debug.Log(collision.tag + collision.gameObject.name);

            // Check if the collided object has the tag "Destination".
            if (collision.tag == "Destination")
            {
                // Log level completion and notify the GameManager.
                Debug.Log("Level Completed");
                GameManager.Instance.LevelCompleted();
            }
        }
    }
}
