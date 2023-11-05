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
        
        private Rigidbody _rb;
        private PlayerMovementController _movementController;
        private bool _canMove = true;
        
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _movementController = GetComponent<PlayerMovementController>();
        }

        private void Start()
        {
            wings.transform.DORotate(wingRotateAngle, 0.1f).SetLoops(-1, LoopType.Yoyo);
        }

        private void OnEnable()
        {
            InputSignals.Instance.OnButtonPressed += OnButtonPressed;
            PlayerSignals.Instance.OnHitPipe += OnHitPipe;
            CoreGameSignals.Instance.OnGameStart += OnGameStart;
            CoreGameSignals.Instance.OnGameRestart += OnGameRestart;
        }

        private void OnDisable()
        {
            InputSignals.Instance.OnButtonPressed -= OnButtonPressed;
            PlayerSignals.Instance.OnHitPipe -= OnHitPipe;
            CoreGameSignals.Instance.OnGameStart += OnGameStart;
            CoreGameSignals.Instance.OnGameRestart += OnGameRestart;
        }

        private void OnHitPipe()
        {
            _canMove = false;
        }

        private void OnGameRestart()
        {
            _rb.useGravity = false;
        }

        private void OnGameStart()
        {
            _rb.useGravity = true;
            _canMove = true;
        }
        
        private void OnButtonPressed()
        {
            if(!_canMove) return;
            _movementController.Jump(jumpForce,_rb);
            _movementController.FlightEffect(transform);
        }

    }
}