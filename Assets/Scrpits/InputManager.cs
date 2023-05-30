using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerController playerController;
    public Vector2 movermentInput;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        if (playerController == null)
        {
            playerController = new PlayerController();
            playerController.PlayerMovement.Movement.performed += i => movermentInput = i.ReadValue<Vector2>();
        }
        playerController.Enable();
    }
    private void OnDisable()
    {
        playerController.Disable();
    }

    // Update is called once per frame
    public void HandleAllInputs()
    {
        HandleMovementInput();
        //HandleJumpingInput();
    }
    private void HandleMovementInput()
    {
        horizontalInput = movermentInput.x;        
    }
}
