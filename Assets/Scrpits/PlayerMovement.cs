using UnityEngine;

namespace CubeRunner
{
    public class PlayerMovement : MonoBehaviour
    {
        public Rigidbody rb;
        public float moveForce = 2000;
        public float sidewayForce = 500;
        InputManager inputManager;

        // Start is called before the first frame update
        void Start()
        {
            inputManager = GetComponent<InputManager>();
        }

        // Update is called once per frame
        void Update()
        {
            inputManager.HandleAllInputs();
        }
        private void FixedUpdate()
        {
            Movement();
            CheckDead();
        }
        public void CheckDead()
        {
            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }

        }
        public void Movement()
        {
            rb.AddForce(0, 0, moveForce * Time.deltaTime);
            MoveLeftRight();

        }
        public void MoveLeftRight()
        {
            rb.AddForce(sidewayForce*inputManager.horizontalInput * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

    }
}


