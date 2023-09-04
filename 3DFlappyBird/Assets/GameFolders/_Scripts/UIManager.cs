using DG.Tweening;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject instructionText;
    [SerializeField] private GameObject startText;
    [SerializeField] private GameObject socialsButton;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text scoreTex2;
    [SerializeField] private TMP_Text highScoreText;
    
    private void Start()
    {
        instructionText.transform.DOScale(new Vector3(0.8f,0.8f,0.8f), 0.8f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutQuad);
    }

    private void Update()
    {
        if (GameManager.Instance.IsGameStarted)
        {
            startText.transform.DOMoveY(1500f, 0.2f);
            instructionText.transform.DOMoveY(-600f, 0.2f);
            socialsButton.transform.DOMoveY(-600f, 0.2f);
            scoreText.gameObject.SetActive(true);
        }

        if (GameManager.Instance.IsGameOver)
        {
            gameOverPanel.transform.DOMoveY(500, 0.3f);
            scoreText.gameObject.SetActive(false);
        }
        
        scoreText.text = GameManager.Instance.Score.ToString();
        scoreTex2.text = "Score : " + GameManager.Instance.Score;
        highScoreText.text = "High Score : " + GameManager.Instance.HighScore;

    }

    public void SocialsButton()
    {
        Application.OpenURL("https://linktr.ee/basarekinci");
    }

    public void RestartButton()
    {
        GameManager.Instance.RestartGame();
    }
}
