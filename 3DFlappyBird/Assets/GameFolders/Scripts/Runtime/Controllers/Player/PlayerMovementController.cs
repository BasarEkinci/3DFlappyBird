using DG.Tweening;
using UnityEngine;
using GameFolders.Scripts.Runtime.Signals;

public class PlayerMovementController : MonoBehaviour
{
    public void Jump(float jumpForce,Rigidbody playerRb)
    {
        playerRb.velocity = Vector3.zero; 
        playerRb.velocity += Vector3.up * jumpForce; 
    }

    public void FlightEffect(Transform playerTransform)
    {
        playerTransform.DORotate(Vector3.left * 20, 0.6f).From().SetLoops(1, LoopType.Yoyo); 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            InputSignals.Instance.OnButtonPressed?.Invoke();
    }
}
