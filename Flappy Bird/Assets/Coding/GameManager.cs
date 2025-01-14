using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
        
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score : "+score;
    }
}
