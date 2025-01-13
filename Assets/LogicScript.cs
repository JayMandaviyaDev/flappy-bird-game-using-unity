using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text initialText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]

    private void Start()
    {
        Destroy(initialText, 3);
    }
    public void addScore(int scoreToAdd) {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }

    public void quitGame() {
        Application.Quit();
    }
}
