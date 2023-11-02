using GameFolders.Scripts.Runtime.Data.UnityObjects;
using GameFolders.Scripts.Runtime.Data.ValueObjects;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameFolders.Scripts.Runtime.Controllers.Obstacles
{
    public class PipeMovementController : MonoBehaviour
    {
        private float _yPos;
        private Vector3 _newPos;
        private Vector3 _moveMultiplier;
        private GameData _data;
        private float _moveSpeed;
        private float _zBound;

        private void Awake()
        {
            _data = GetData();
        }

        private void Start()
        {
            _moveSpeed = 6;
            _moveMultiplier = new Vector3(0, 0, -_moveSpeed);
            _zBound = -14f;
            _newPos = new Vector3(-20, _yPos, 25);
        }

        private void Update()
        {
            SetPos();
            Move();
        }
        private void Move()
        {
            if(!_data.IsGameOver)
                transform.position += _moveMultiplier * Time.deltaTime;
        }
        private void SetPos()
        {
            if (transform.position.z <= _zBound)
            {
                _yPos = Random.Range(-6, 9);
                _newPos.y = _yPos;
                transform.position = _newPos;
            }
        }

        private GameData GetData()
        {
            return Resources.Load<CD_GameData>("Data/CD_GameData").gameData;
        }
    }
}