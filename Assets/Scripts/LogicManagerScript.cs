using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore = 0;
    public bool isGameOver = false;

    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreDingSFX;

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
        scoreDingSFX.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void TriggerGameOver()
    {
        isGameOver = true;
        gameOverScreen.SetActive(true);
    }
}
