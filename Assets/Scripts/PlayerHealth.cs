using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    [SerializeField] private TMP_Text healthText;

    void Start()
    {
        ResetHealth();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateUI();

        if (currentHealth <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("GAME OVER");
        Time.timeScale = 0f;
    }

    public void ResetHealth()
    {
        currentHealth = maxHealth;
        Time.timeScale = 1f;
        UpdateUI();
    }

    public void UpdateUI()
    {
        healthText.text = "Health: " + currentHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            TakeDamage(10);
        }
    }
}
