using System;
using UnityEngine;

namespace GameFolders.Scripts.Runtime.Controllers.Player
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        private void OnEnable()
        {
            PlayerSignals.Instance.OnHitPipe += OnHitPipe;
            PlayerSignals.Instance.OnPipePassed += OnPipePassed;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Pipe"))
            {
                OnHitPipe();
            }
            if (other.CompareTag("Point"))
            {
                OnPipePassed();
            }
        }

        private void OnPipePassed()
        {
            PlayerSignals.Instance.OnPipePassed?.Invoke();
            Debug.Log("Pipe Passed Method Triggered");
        }

        private void OnHitPipe()
        {
            PlayerSignals.Instance.OnHitPipe?.Invoke();
            Debug.Log("Pipe Hit Method Triggered");
        }
        
        private void OnDisable()
        {
            PlayerSignals.Instance.OnHitPipe -= OnHitPipe;
            PlayerSignals.Instance.OnPipePassed -= OnPipePassed;
        }
    }
}