using Runtime.Data.UnityObjects;
using Runtime.Data.ValueObjects;
using Runtime.Signals;
using UnityEngine;

namespace Runtime.Managers
{
    public class PlayerManager : MonoBehaviour
    {
        private PlayerData playerData;
        private GameData gameData;
        private void Awake()
        {
            playerData = GetPlayerData();
            gameData = GetGameData();
        }
        private PlayerData GetPlayerData()
        {
            return Resources.Load<CD_Player>("Data/CD_Player").PlayerData;
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
            CoreGameSignals.Instance.OnPipePassed += OnPipePassed;
            CoreGameSignals.Instance.OnCrashPipe += OnCrashPipe;
        }

        private void OnCrashPipe()
        {
            
        }

        private void OnPipePassed()
        {
            
        }

        private void UnsubscribeEvents()
        {
            CoreGameSignals.Instance.OnPipePassed -= OnPipePassed;
            CoreGameSignals.Instance.OnCrashPipe -= OnCrashPipe;
        }

    }
}