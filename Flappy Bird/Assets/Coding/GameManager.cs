using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI scoreText;
    public Button restartButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
        restartButton.onClick.AddListener(() => restartGame());
        restartButton.gameObject.SetActive(false);
    }

    public void restartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    void OnPlayerDie()
    {
        Time.timeScale = 0f;
        scoreText.text = "Perdu !\nVotre score : " + score;
        
        restartButton.gameObject.SetActive(true);
    }

    public void killPlayer()
    {
        OnPlayerDie();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            restartGame();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
        }
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score : "+score;
    }
}
