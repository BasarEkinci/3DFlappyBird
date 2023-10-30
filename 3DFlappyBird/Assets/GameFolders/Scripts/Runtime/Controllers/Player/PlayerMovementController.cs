using DG.Tweening;
using UnityEngine;
using GameFolders.Scripts.Runtime.Signals;

public class PlayerMovementController : MonoBehaviour
{
    private float jumpForce;
    private Rigidbody playerRb;
    private bool canMove;
    private Transform pTransform;

    public PlayerMovementController(Rigidbody playerRb,float jumpForce,bool canMove,Transform pTransform)
    {
        this.playerRb = playerRb;
        this.jumpForce = jumpForce;
        this.canMove = canMove;
        this.pTransform = pTransform;
    }
    public void Jump()
    {
        playerRb.velocity = Vector3.zero; 
        playerRb.velocity += new Vector3(0, jumpForce, 0); 
    }

    public void FlightEffect()
    {
        pTransform.DORotate(Vector3.left * 20, 0.1f).From().SetLoops(1, LoopType.Yoyo); 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            InputSignals.Instance.OnButtonPressed?.Invoke();
    }
}
