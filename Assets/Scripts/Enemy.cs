using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 20;
    public int scorePenalty = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.TakeDamage(damage);
            
            // Decrease score when hit by enemy
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(-scorePenalty); // Penalty for hitting enemy
            }
            
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}

