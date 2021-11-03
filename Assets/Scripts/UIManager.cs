using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private Text lifeText;
    [SerializeField] private Text scoreText;

    private int lifeCount = 3, scoreCount = 0;

    private void Start()
    {
        lifeText.text = "Lives = " + lifeCount;
        scoreText.text = "Score = " + scoreCount;
    }

    public void DecreaseLives()
    {
        lifeCount--;
        lifeText.text = "Lives = " + lifeCount;

        if(lifeCount == 0)
        {
            GameOver();
        }
    }

    public void IncreaseScore(int scoreValue)
    {
        scoreCount += scoreValue;
        scoreText.text = "Score = " + scoreCount;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Prototype 2");
    }

    private void GameOver()
    {
        gameoverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
