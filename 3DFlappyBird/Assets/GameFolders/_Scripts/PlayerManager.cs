using System;
using UnityEngine;
using DG.Tweening;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float jumpForce;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            Debug.Log("Point +1");
        }
        else
        {
            GameManager.Instance.GameOver();
        }
    }

    private void Jump()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * jumpForce);
    }
}
