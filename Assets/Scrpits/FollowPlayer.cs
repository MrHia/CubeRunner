using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeRunner
{
    public class FollowPlayer : MonoBehaviour
    {
        public Transform player;
        public Vector3 offset;


        // Update is called once per frame
        void Update()
        {
            this.transform.position = player.position + offset;
        }
    }

}