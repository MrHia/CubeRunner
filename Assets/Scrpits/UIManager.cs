using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CubeRunner
{

    public class UIManager : MonoBehaviour
    {
        public Transform player;
        public TMP_Text score;
        private void Start()
        {

        }
        private void Update()
        {

            DisplayScore();
        }
        public void DisplayScore()
        {
            if (!FindObjectOfType<GameManager>().gameHasEnded)
                score.text = player.position.z.ToString("0");
        }
    }
}