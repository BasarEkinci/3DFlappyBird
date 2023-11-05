using DG.Tweening;
using GameFolders.Scripts.Runtime.Signals;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


namespace GameFolders.Scripts.Runtime.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject startPanel;
        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private TMP_Text startText;
        [SerializeField] private TMP_Text playText;
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private TMP_Text scoreText2;
        [SerializeField] private TMP_Text highScoreText;

        private int _score;
        private int _highScore;
        private bool _isGameStarted;

        private void OnEnable()
        {
            CoreGameSignals.Instance.OnGameStart += OnGameStart;
            CoreGameSignals.Instance.OnGameOver += OnGameOver;
            CoreGameSignals.Instance.OnGameRestart += OnGameRestart;
            PlayerSignals.Instance.OnPipePassed += OnPipePassed;
            InputSignals.Instance.OnButtonPressed += OnButtonPressed;
        }

        private void Start()
        {
            startText.rectTransform.DOMoveY(startText.rectTransform.position.y + 10f, 1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
            playText.transform.DOScale(Vector3.one * 2.1f, 1.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        }

        private void OnApplicationQuit()
        {
            PlayerPrefs.DeleteAll();
        }

        private void OnDisable()
        {
            CoreGameSignals.Instance.OnGameOver -= OnGameOver;
            CoreGameSignals.Instance.OnGameStart -= OnGameStart;
            CoreGameSignals.Instance.OnGameRestart -= OnGameRestart;
            InputSignals.Instance.OnButtonPressed -= OnButtonPressed;
            PlayerSignals.Instance.OnPipePassed -= OnPipePassed;
        }

        private void OnPipePassed()
        {
            _score++;
            if (_score > _highScore)
            {
                _highScore = _score;
                PlayerPrefs.SetInt("HighScore",_highScore);
                PlayerPrefs.Save();
            }

            scoreText.text = _score.ToString();
        }

        private void OnButtonPressed()
        {
            CoreGameSignals.Instance.OnGameStart?.Invoke();
        }

        public void OnGameRestart()
        {
            _score = 0;
            _isGameStarted = false;
            SceneManager.LoadScene(0);
        }

        private void OnGameStart()
        {
            if (_isGameStarted) return;
            scoreText.rectTransform.DOMoveY(scoreText.rectTransform.position.y - 450f, 0.1f);
            startPanel.transform.DOScale(Vector3.zero, 0.1f);
            _isGameStarted = true;
        }

        private void OnGameOver()
        {
            highScoreText.text = "High Score: " + _highScore;
            scoreText2.text = "Score: " + _score;
            gameOverPanel.transform.DOScale(Vector3.one * 2, 0.3f);
        }

        public void OpenLink(string link)
        {
            Application.OpenURL(link);
        }
    }
}