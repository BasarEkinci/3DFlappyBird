using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public bool IsGameStarted { get; set; }
    public bool IsGameOver { get; private set; }
    
    private void Awake()
    {
        Instance = this;
    }

    public void GameOver()
    {
        
    }
}
