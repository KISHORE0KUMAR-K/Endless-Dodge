using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    bool gameOver = false;
    int score = 0;
     
     public Text scoreText;
     public GameObject gameOverPanel;
    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    public void GameOver()
    {
       gameOver = true;

       GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();
       gameOverPanel.SetActive(true);
    }
    public void IncrementScore()
    {
        if(!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            
        }
    }
    public void Restart()
    {
      SceneManager.LoadScene("Game");

    }

    public void Menu()
    {
      SceneManager.LoadScene("MainMenu");

    }
}
