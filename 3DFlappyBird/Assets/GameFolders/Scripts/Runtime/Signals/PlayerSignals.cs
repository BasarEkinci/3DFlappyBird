using UnityEngine.Events;

public class PlayerSignals : MonoSingelton<PlayerSignals>
{
    public UnityAction OnPipePassed = delegate {  };
    public UnityAction OnHitPipe = delegate {  };
}
