using System;
using UnityEngine;

namespace Runtime.Controllers.Player
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        private string pointAreaTag = "PointArea";
        private string pipeTag = "Pipe";

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag(pointAreaTag))
            {
                return;
            }
            if (other.gameObject.CompareTag(pipeTag))
            {
                return;
            }
        }
    }
}