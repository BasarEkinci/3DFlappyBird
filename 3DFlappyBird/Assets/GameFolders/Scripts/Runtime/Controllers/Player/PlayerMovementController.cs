using UnityEngine;
using DG.Tweening;
public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    
    private Rigidbody playerRb;
    private bool isButtonPressed;
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        IsButtonPressed();
    }

    private void FixedUpdate()
    {
        Jump();
    }

    private void Jump()
    {
        if (IsButtonPressed())
        {
            playerRb.velocity = Vector3.zero;
            transform.DORotate(Vector3.left * 15, 0.1f).From().SetLoops(2, LoopType.Yoyo);
            playerRb.velocity += new Vector3(0, jumpForce, 0) * Time.deltaTime;
            isButtonPressed = false;
        }
    }
    private bool IsButtonPressed()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isButtonPressed)
            isButtonPressed = true;
        else if(Input.GetKeyUp(KeyCode.Space))
            isButtonPressed = false;

        return isButtonPressed;
    }
}
