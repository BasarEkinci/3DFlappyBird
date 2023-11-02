using System;
using GameFolders.Scripts.Runtime.Controllers.Obstacles;
using GameFolders.Scripts.Runtime.Data.UnityObjects;
using GameFolders.Scripts.Runtime.Data.ValueObjects;
using GameFolders.Scripts.Runtime.Signals;
using UnityEngine;

namespace GameFolders.Scripts.Runtime.Managers
{
    public class ObstacleManager : MonoBehaviour
    {
        private PipeMovementController _pipe;
        private GroundMovementController _ground;
        private PipeData _pipeData;
        private GroundData _groundData;
        private GameData _gameData;
        private float _zBound;
        private float _Bound;
        private float _yPos;
        private void Awake()
        {
            _pipe = new PipeMovementController();
            _ground = new GroundMovementController();
            _pipeData = Resources.Load<CD_ObstacleData>("Data/CD_ObstacleData").pipeData;
            _groundData = Resources.Load<CD_ObstacleData>("Data/CD_ObstacleData").groundData;
            _gameData = Resources.Load<CD_GameData>("Data/CD_GameData").gameData;
        }

        private void OnEnable()
        {
            CoreGameSignals.Instance.OnGameOver += OnGameOver;
        }

        private void OnDisable()
        {
            CoreGameSignals.Instance.OnGameOver -= OnGameOver;
        }

        private void OnGameOver()
        {
            _gameData.IsGameOver = true;
        }

        private void Update()
        {
            if(_gameData.IsGameOver) return;
            
            _pipe.Move(_pipeData.moveSpeed);
            _pipe.SetPosition(_yPos,_pipeData.zBound);
            _ground.Move(_groundData.moveSpeed);
            _ground.SetPosition(_groundData.zBound,_groundData.newZBound);
        }
    }
}