using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace test
{
    public class TestMove : MonoBehaviour
    {
        PlayerController playerController;
        public Vector2 moveInput;
        public float direction = 0;
        public float horizontalInput;
        public float verticalInput;
        public Rigidbody rb;
        public float sidewayForce = 500;
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            if (playerController == null)
            {
                playerController = new PlayerController();
                playerController.PlayerMovement.Movement.performed += i => moveInput = i.ReadValue<Vector2>();
            }
            playerController.Enable();
        }
        private void OnDisable()
        {
            playerController.Disable();
        }
        
        private void HandleMovementInput()
        {
            verticalInput = moveInput.y;
            horizontalInput = moveInput.x;
           /* moveAmount = Mathf.Clamp01(Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));
            animatorManager.UpdateAnimatorValues(0, moveAmount);*/
        }

        // Update is called once per frame
        void Update()
        {
            HandleMovementInput();
            Moving();
        }
        public void Moving()
        {
            rb.AddForce(sidewayForce* horizontalInput * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

}
