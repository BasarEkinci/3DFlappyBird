using System;
using Unity.Mathematics;

namespace Runtime.Data.ValueObjects
{
    [Serializable]
    public struct PlayerData
    {
        public PlayerForceData ForceData;
    }
    
    [Serializable]
    public struct PlayerForceData
    {
        public float3 ForceParameters;
    }
}