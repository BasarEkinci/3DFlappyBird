using System;

namespace Runtime.Data.ValueObjects
{
    [Serializable]
    public struct GameData
    {
        public float Score;
        public float HighScore;
        public bool IsGameStarted;
        public bool IsGameOver;
    }
}