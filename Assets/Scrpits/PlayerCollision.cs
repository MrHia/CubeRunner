using CubeRunner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeRunner
{
    public class PlayerCollision : MonoBehaviour
    {
        public PlayerMovement playerMoverment;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Obstacle"))
            {
                Debug.Log("On cliider");
                playerMoverment.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}