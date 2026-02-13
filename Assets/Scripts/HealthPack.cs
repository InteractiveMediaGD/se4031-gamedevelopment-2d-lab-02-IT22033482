using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healAmount = 20;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.currentHealth = Mathf.Min(player.currentHealth + healAmount, player.maxHealth);
            player.UpdateUI();
            
            // Update score
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(10); // Award points for collecting health pack
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

