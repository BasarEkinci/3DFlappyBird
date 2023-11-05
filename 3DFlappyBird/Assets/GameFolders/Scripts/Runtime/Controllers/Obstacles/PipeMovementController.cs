using System;
using GameFolders.Scripts.Runtime.Signals;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameFolders.Scripts.Runtime.Controllers.Obstacles
{
    public class PipeMovementController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private float zBound;
        [SerializeField] private float minPos;
        [SerializeField] private float maxPos;

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

        private void Move()
        {
            Vector3 moveMultiplier = Vector3.back * moveSpeed;
            transform.position += moveMultiplier * Time.deltaTime;
        }

        private void SetPosition()
        {
            if (transform.position.z <= zBound)
            {
                float yPos = Random.Range(minPos, maxPos);
                transform.position = new Vector3(-20, yPos, 25);
            }     
        }

        private void Update()
        {
            if(!_canMove) return;
            
            Move();
            SetPosition();
        }
    }
}