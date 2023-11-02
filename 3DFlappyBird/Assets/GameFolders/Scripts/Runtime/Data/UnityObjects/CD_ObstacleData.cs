using GameFolders.Scripts.Runtime.Data.ValueObjects;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameFolders.Scripts.Runtime.Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_GameData",menuName = "FlappyBird3D/CD_ObstacleData")]
    public class CD_ObstacleData : ScriptableObject
    {
         public PipeData pipeData;
         public GroundData groundData;
    }
}