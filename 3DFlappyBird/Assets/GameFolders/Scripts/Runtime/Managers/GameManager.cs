using GameFolders.Scripts.Runtime.Data.UnityObjects;
using GameFolders.Scripts.Runtime.Data.ValueObjects;
using UnityEngine;

namespace GameFolders.Scripts.Runtime.Managers
{
    public class GameManager : MonoBehaviour
    {
        private GameData _data;
        private int _score;

        private void Awake()
        {
            _score = GetData().Score;
        }

        private void OnEnable()
        {
            PlayerSignals.Instance.OnPipePassed += OnPipePassed;
        }

        private void OnDisable()
        {
            PlayerSignals.Instance.OnPipePassed -= OnPipePassed;
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