using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class AnimalController : MonoBehaviour
{
    PlayerInput playerInput;

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
            Vector2 input = context.ReadValue<Vector2>();   
            Vector2 newPos = transform.position;
            newPos.x += input.x; 
            newPos.y += input.y;

            transform.position = newPos;
        }
    }

}
