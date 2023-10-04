using Runtime.Signals;
using UnityEngine;

namespace Runtime.Controllers.Player
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        private string pointAreaTag = "PointArea";
        private string pipeTag = "Pipe";
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag(pointAreaTag))
            {
                CoreGameSignals.Instance.OnPipePassed?.Invoke();
                return;
            }
            if (other.gameObject.CompareTag(pipeTag))
            {
                CoreGameSignals.Instance.OnCrashPipe?.Invoke();
                CoreGameSignals.Instance.OnGameOver?.Invoke();  
                return;
            }
        }
    }
}