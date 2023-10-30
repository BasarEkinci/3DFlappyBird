using UnityEngine.Events;

namespace GameFolders.Scripts.Runtime.Signals
{
    public class InputSignals : MonoSingelton<InputSignals>
    {
        public UnityAction OnButtonPressed = delegate {  };
        public UnityAction OnEnableInput = delegate {  };
        public UnityAction OnDisableInput = delegate {  };
    }
}