using Runtime.Extentions;
using UnityEngine.Events;

namespace Runtime.Signals
{
    public class PlayerSignals : MonoSingelton<PlayerSignals>
    {
        public UnityAction OnPipePassed = delegate {  };
        public UnityAction OnCrashPipe = delegate { };
    }
}