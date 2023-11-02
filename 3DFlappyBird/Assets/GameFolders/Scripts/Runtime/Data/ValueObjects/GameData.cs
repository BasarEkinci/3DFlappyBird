using System;

namespace GameFolders.Scripts.Runtime.Data.ValueObjects
{
    [Serializable]
    public struct GameData
    {
        internal int GameSpeed;
        internal int Score;
        internal int HighScore;
        internal bool IsGameOver;
    }
}