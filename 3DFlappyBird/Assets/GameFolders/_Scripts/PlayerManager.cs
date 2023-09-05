using UnityEngine;
using DG.Tweening;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float jumpForce; 
    [SerializeField] float jumpRotateAngle;
    [SerializeField] float jumpRotateDuration;
    [SerializeField] float wingsRotateAngle;
    [SerializeField] float wingsRotateDuration;
    [SerializeField] GameObject wings;
    
    private Rigidbody rb;
    
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        wings.transform.DORotate(Vector3.right * wingsRotateAngle, wingsRotateDuration).SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
    private void Update()
    {
        Jump();
        rb.useGravity = GameManager.Instance.IsGameStarted;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
            GameManager.Instance.IncreaseScore();
        else if(other.gameObject.CompareTag("Pipe"))
            GameManager.Instance.GameOver();
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.zero;
            transform.DORotate(Vector3.left * jumpRotateAngle, jumpRotateDuration).SetLoops(2, LoopType.Yoyo);
            rb.AddForce(Vector3.up * jumpForce);
            SoundManager.Instance.PlayOneShot(1);
        }
    }
}
