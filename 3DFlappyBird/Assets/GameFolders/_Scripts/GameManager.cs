using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] GameObject player;
    public bool IsGameStarted { get; set; }
    public bool IsGameOver { get; private set; }
    public int Score { get; set; }
    public int HighScore { get; private set; }

    private Collider playerCollider;
    private Camera gameCam;
    private float cameraShakeDuration = 0.1f;
    
    
    private void Awake()
    {
        Instance = this;
        playerCollider = player.GetComponent<Collider>();
        gameCam = Camera.main;
    }

    private void Start()
    {
        IsGameStarted = false;
    }

    private void Update()
    {
        if (!IsGameStarted && Input.GetKeyDown(KeyCode.Space))
            IsGameStarted = true;

        SetHighScore();
        
        if(transform.position.y >= 25f || transform.position.y == -7f)
        {
            GameOver();
        }
    }

    private void SetHighScore()
    {
        if (Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt("HighScore",HighScore);
            PlayerPrefs.Save();
        }
        HighScore = PlayerPrefs.GetInt("HighScore");
    }

    public void GameOver()
    {
        IsGameOver = true;
        SoundManager.Instance.PlayOneShot(0);
        playerCollider.enabled = false;
        gameCam.transform.DOShakePosition(cameraShakeDuration).SetLoops(1,LoopType.Yoyo);
    }

    public void IncreaseScore()
    {
        Score++;
        SoundManager.Instance.PlayOneShot(2);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        playerCollider.enabled = true;
        IsGameStarted = false;
        IsGameOver = false;
    }
}
