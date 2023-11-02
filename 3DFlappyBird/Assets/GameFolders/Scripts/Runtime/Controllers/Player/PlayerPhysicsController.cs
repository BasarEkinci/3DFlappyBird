using GameFolders.Scripts.Runtime.Signals;
using UnityEngine;

namespace GameFolders.Scripts.Runtime.Controllers.Player
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Pipe"))
            {
                PlayerSignals.Instance.OnHitPipe?.Invoke();
                CoreGameSignals.Instance.OnGameOver?.Invoke();
            }
            if (other.CompareTag("Point"))
            {
                PlayerSignals.Instance.OnPipePassed?.Invoke();
            }
        }
    }
}