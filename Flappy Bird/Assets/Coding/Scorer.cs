using UnityEngine;

public class Scorer : MonoBehaviour
{
    GameManager gameManager;

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player _player = collision.gameObject.GetComponent<Player>();
        if (_player != null)
        {
            gameManager.AddScore();
        }

    }
}
