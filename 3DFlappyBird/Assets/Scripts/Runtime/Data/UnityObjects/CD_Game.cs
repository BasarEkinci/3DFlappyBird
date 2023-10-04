using Runtime.Data.ValueObjects;
using UnityEngine;
using UnityEngine.Serialization;

namespace Runtime.Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_Game", menuName = "FlappyBird3D/CD_Game")]
    public class CD_Game : ScriptableObject
    {
        [FormerlySerializedAs("gameData")] public GameData GameData;
    }
}