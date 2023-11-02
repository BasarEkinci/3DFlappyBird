using UnityEngine.Events;

namespace GameFolders.Scripts.Runtime.Signals
{
    public class CoreGameSignals : MonoSingelton<CoreGameSignals>
    {
        public UnityAction OnGameOver = delegate {  };
        public UnityAction OnGameRestart = delegate {  };
        public UnityAction OnGameStart = delegate {  };
    }
}