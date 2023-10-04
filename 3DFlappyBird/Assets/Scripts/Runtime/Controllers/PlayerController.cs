using Runtime.Data.UnityObjects;
using Runtime.Data.ValueObjects;
using UnityEngine;

namespace Runtime.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerData _data;

        private void Awake()
        {
            _data = GetPlayerData();
        }

        private PlayerData GetPlayerData()
        {
            return Resources.Load<CD_Player>("CD_Player").PlayerData;
        }
    }
}