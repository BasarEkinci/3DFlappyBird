using System;

namespace GameFolders.Scripts.Runtime.Data.ValueObjects
{
    [Serializable]
    public struct GameData
    {
        public int GameSpeed;
        internal int Score;
        internal int HighScore;
    }
}