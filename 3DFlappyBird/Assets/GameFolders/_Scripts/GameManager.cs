using System;
using DG.Tweening;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public bool IsGameStarted { get; set; }
    public bool IsGameOver { get; private set; }
    public int Score { get; set; }
    public int HighScore { get; private set; }
    
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        IsGameStarted = false;
    }

    private void Update()
    {
        if (!IsGameStarted && Input.GetKeyDown(KeyCode.Space))
            IsGameStarted = true;
    }

    public void GameOver()
    {
        IsGameOver = true;
        Camera.main.transform.DOShakePosition(0.1f).SetLoops(1,LoopType.Yoyo);
    }
}
