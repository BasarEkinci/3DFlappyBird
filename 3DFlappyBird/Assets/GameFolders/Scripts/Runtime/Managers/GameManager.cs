using System;
using GameFolders.Scripts.Runtime.Data.UnityObjects;
using GameFolders.Scripts.Runtime.Data.ValueObjects;
using GameFolders.Scripts.Runtime.Signals;
using UnityEngine;

namespace GameFolders.Scripts.Runtime.Managers
{
    public class GameManager : MonoBehaviour
    {
        private GameData _data;
        private int _score;

        private void Awake()
        {
            _data = GetData();
            _score = _data.Score;
        }
        private void OnEnable()
        {
            PlayerSignals.Instance.OnPipePassed += OnPipePassed;
            CoreGameSignals.Instance.OnGameStart += OnGameStart;
            PlayerSignals.Instance.OnHitPipe += OnHitPipe;
        }

        private void OnDisable()
        {
            PlayerSignals.Instance.OnPipePassed -= OnPipePassed;
            PlayerSignals.Instance.OnHitPipe -= OnHitPipe;
            CoreGameSignals.Instance.OnGameStart -= OnGameStart;
        }

        private void OnGameStart()
        {
            _data.GameSpeed = 3;
        }

        private void OnHitPipe()
        {
            Debug.Log("Hit the Pipe");
            _data.IsGameOver = true;
        }

        private void OnPipePassed()
        {
            _score++;
        }

        private GameData GetData()
        {
            return Resources.Load<CD_GameData>("Data/CD_GameData").gameData;
        }
    }
}