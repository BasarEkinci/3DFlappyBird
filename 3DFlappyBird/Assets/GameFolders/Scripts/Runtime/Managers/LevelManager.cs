using GameFolders.Scripts.Runtime.Signals;
using UnityEngine;

namespace GameFolders.Scripts.Runtime.Managers
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private GameObject level;
        private void OnEnable()
        {
            CoreGameSignals.Instance.OnGameRestart += OnGameRestart;
        }

        private void OnDisable()
        {
            CoreGameSignals.Instance.OnGameRestart += OnGameRestart;
        }

        private void OnGameRestart()
        {
            Instantiate(level, Vector3.zero, transform.rotation);
        }
    }
}