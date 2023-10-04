using System;
using Runtime.Data.UnityObjects;
using Runtime.Data.ValueObjects;
using Runtime.Signals;
using UnityEngine;

namespace Runtime.Managers
{
    public class GameManager : MonoBehaviour
    {
        private GameData gameData;
        
        private void Awake()
        {
            gameData = GetGameData();
        }

        private GameData GetGameData()
        {
            return Resources.Load<CD_Game>("Data/CD_Game").GameData;
        }

        private void OnEnable()
        {
            SubscribeEvents();
        }
        private void OnDisable()
        {
            UnsubscribeEvents();   
        }
        private void SubscribeEvents()
        {
            CoreGameSignals.Instance.OnRestartGame += OnRestartGame;
            CoreGameSignals.Instance.OnRestartGame -= OnRestartGame;
        }
        private void UnsubscribeEvents()
        {
            CoreGameSignals.Instance.OnGameStart -= OnGameStart;
            CoreGameSignals.Instance.OnRestartGame -= OnRestartGame;
        }
        private void OnRestartGame()
        {
            gameData.Score = 0;
            gameData.IsGameStarted = false;
            gameData.IsGameOver = false;
        }
        private void OnGameStart()
        {
            gameData.IsGameStarted = true;
            gameData.IsGameOver = false;
        }
    }
}