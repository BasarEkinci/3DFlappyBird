using Runtime.Data.ValueObjects;
using UnityEngine;

namespace Runtime.Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_Player", menuName = "FlappyBird3D/CD_Player")]
    public class CD_Player : ScriptableObject
    {
        public PlayerData PlayerData;
    }
}