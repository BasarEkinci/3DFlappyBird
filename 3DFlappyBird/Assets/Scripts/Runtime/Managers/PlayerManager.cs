using Runtime.Data.UnityObjects;
using Runtime.Data.ValueObjects;
using UnityEngine;

namespace Runtime.Managers
{
    public class PlayerManager : MonoBehaviour
    {
        private PlayerData data;
        private void Awake()
        {
            data = GetPlayerData();
        }
        private PlayerData GetPlayerData()
        {
            return Resources.Load<CD_Player>("Data/CD_Player").PlayerData;
        }
    }
}