using System;

namespace GameFolders.Scripts.Runtime.Data.ValueObjects
{
    [Serializable]
    public struct GameData
    {
        public int GameSpeed;
        public int Score;
        public int HighScore;
    }
}