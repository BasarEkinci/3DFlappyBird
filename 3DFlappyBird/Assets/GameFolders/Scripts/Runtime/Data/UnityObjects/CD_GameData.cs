using GameFolders.Scripts.Runtime.Data.ValueObjects;
using UnityEngine;

namespace GameFolders.Scripts.Runtime.Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_GameData",menuName = "FlappyBird3D/CD_GameData")]
    public class CD_GameData : ScriptableObject
    {
        public GameData gameData;
    }
}