using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeRunner
{
    public class EndTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }

}

