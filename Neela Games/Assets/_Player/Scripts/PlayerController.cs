using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NeelaGames.AnimalRescue
{
    public class PlayerController : MonoBehaviour
    {
        PlayerInput playerInput;
        public LayerMask backgroundMask;

        private void Awake()
        {
            playerInput = GetComponent<PlayerInput>();
        }

        private void OnEnable()
        {

        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Move(InputAction.CallbackContext context)
        {
            if (context.performed)
            {

                Debug.Log(context.ReadValue<Vector2>());
                Vector2 input = context.ReadValue<Vector2>();//x-> 1, -1  y -> 1, -1

                Vector2 newPos = transform.position;



                //Moving up
                if (input == Vector2.up && !Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), 0.25f, backgroundMask))
                {
                    newPos.y += 1;
                }
                //Moving Down
                if (input == Vector2.down && !Physics2D.OverlapCircle(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), 0.25f, backgroundMask))
                {
                    newPos.y -= 1;
                }
                //Moving Right
                if (input == Vector2.right && !Physics2D.OverlapCircle(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), 0.25f, backgroundMask))
                {
                    newPos.x += 1;
                }
                //Moving Left
                if (input == Vector2.left && !Physics2D.OverlapCircle(new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), 0.25f, backgroundMask))
                {
                    newPos.x -= 1;
                }
                transform.position = newPos;
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireSphere(new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), 0.25f);
            Gizmos.DrawWireSphere(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), 0.25f);

            Gizmos.DrawWireSphere(new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), 0.25f);
            Gizmos.DrawWireSphere(new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), 0.25f);

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log(collision.tag + collision.gameObject.name);
            if (collision.tag == "Destination") 
            {
                Debug.Log("Level Completed");
                GameManager.Instance.LevelCompleted();
            }
        }
    }
}
