using GameFolders.Scripts.Runtime.Data.UnityObjects;
using GameFolders.Scripts.Runtime.Data.ValueObjects;
using UnityEngine;

public class ObstacleMovementController : MonoBehaviour
{
    private GameData _gameData;
    private float _moveSpeed;
    private float _minZBound;
    private Vector3 _moveMultiplier;
    private Vector3 _newPos;

    private void Awake()
    {
        _gameData = Resources.Load<CD_GameData>("Data/CD_GameData").gameData;
    }
    private void Start()
    {
        _moveMultiplier = new Vector3(0, 0, -_moveSpeed);
        _newPos = new Vector3(-20f, -16f, 25.4f);
        _minZBound = -24.6f;
        _moveSpeed = 3;
    }
    private void Update()
    {
        Move();
    }
    private void Move()
    {
        if (_gameData.IsGameOver) return;
        
        transform.position += _moveMultiplier * Time.deltaTime;
        if (transform.position.z <= _minZBound)
        {
            transform.position = _newPos;
        }
    }
}
