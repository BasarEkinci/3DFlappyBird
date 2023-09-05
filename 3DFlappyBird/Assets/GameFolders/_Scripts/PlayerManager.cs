using UnityEngine;
using DG.Tweening;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] float wingsAngle;
    [SerializeField] float wingsAnimationDuration;
    [SerializeField] GameObject wings;
    
    private Rigidbody rb;
    
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        wings.transform.DORotate(Vector3.right * 20, 0.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }

    private void Update()
    {
        Jump();
        rb.useGravity = GameManager.Instance.IsGameStarted;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
            GameManager.Instance.Score++;
        else if(other.gameObject.CompareTag("Pipe"))
            GameManager.Instance.GameOver();
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.zero;
            transform.DORotate(Vector3.left * wingsAngle, wingsAnimationDuration).SetLoops(2, LoopType.Yoyo);
            rb.AddForce(Vector3.up * jumpForce);
            SoundManager.Instance.PlayOneShot(1);
        }
    }
}
