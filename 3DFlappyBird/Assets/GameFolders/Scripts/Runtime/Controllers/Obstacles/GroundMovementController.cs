using GameFolders.Scripts.Runtime.Signals;
using UnityEngine;

namespace GameFolders.Scripts.Runtime.Controllers.Obstacles
{
    public class GroundMovementController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private float zBound;
        [SerializeField] private float newZPos;

        private bool _canMove;
        
        private void OnEnable()
        {
            CoreGameSignals.Instance.OnGameOver += OnGameOver;
            CoreGameSignals.Instance.OnGameStart += OnGameStart;
        }

        private void OnDisable()
        {
            CoreGameSignals.Instance.OnGameOver -= OnGameOver;
            CoreGameSignals.Instance.OnGameStart -= OnGameStart;
        }
        private void OnGameStart()
        {
            _canMove = true;
        }
        private void OnGameOver()
        {
            _canMove = false;
        }

        private void Update()
        {
            if (!_canMove) return;
            Move();
            SetPosition();
        }

        private void Move()
        {
            transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
        }
        private void SetPosition()
        {
            if (transform.position.z <= zBound)
            {
                transform.position = Vector3.forward * newZPos;
            }
        }
        
        
    }
}