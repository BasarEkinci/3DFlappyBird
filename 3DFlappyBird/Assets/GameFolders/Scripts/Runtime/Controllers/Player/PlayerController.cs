using UnityEngine;

public class PlayerController : MonoBehaviour
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
            playerRb.velocity += new Vector3(0, jumpForce, 0) * Time.deltaTime;
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
