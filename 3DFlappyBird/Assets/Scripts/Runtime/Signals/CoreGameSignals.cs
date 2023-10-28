using Runtime.Extentions;
using UnityEngine.Events;

namespace Runtime.Signals
{
    public class CoreGameSignals :MonoSingelton<CoreGameSignals>
    {
        public UnityAction OnRestartGame = delegate {  };
        public UnityAction OnGameOver = delegate {  };
        public UnityAction OnGameStart = delegate {  };
    }
}