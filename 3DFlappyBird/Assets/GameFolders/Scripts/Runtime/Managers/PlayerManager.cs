using System;
using DG.Tweening;
using GameFolders.Scripts.Runtime.Signals;
using UnityEngine;


namespace GameFolders.Scripts.Runtime.Managers
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField] private Vector3 wingRotateAngle;
        [SerializeField] private GameObject wings;
        [SerializeField] private float jumpForce;
        
        private Rigidbody rb;
        private PlayerMovementController _movementController;
        private bool canMove = true;
        
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            _movementController = new PlayerMovementController(rb, jumpForce,canMove,transform);
        }

        private void Start()
        {
            wings.transform.DORotate(wingRotateAngle, 0.1f).SetLoops(-1, LoopType.Yoyo);
        }

        private void OnEnable()
        {
            InputSignals.Instance.OnButtonPressed += OnButtonPressed;
            InputSignals.Instance.OnDisableInput += OnDisableInput;
        }

        private void OnDisable()
        {
            InputSignals.Instance.OnButtonPressed -= OnButtonPressed;
            InputSignals.Instance.OnDisableInput -= OnDisableInput;
        }
        private void OnDisableInput()
        {
            canMove = false;
        }
        private void OnButtonPressed()
        {
            _movementController.Jump();
            _movementController.FlightEffect();
        }

    }
}