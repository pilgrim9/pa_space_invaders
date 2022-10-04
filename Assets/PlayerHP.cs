using UnityEngine;

public class PlayerHP : MonoBehaviour, ITakeDamage
{
    public int maxHP = 3;
    public int currentHP;
    public HealthBar healthBar;

    private void Start()
    {
        currentHP = maxHP;
        healthBar.SetHealth(maxHP);
    }

    public bool TakeDamage(string fromTag)
    {
        if (fromTag != "Enemy" && fromTag != "EnemyBullet") return false;
        currentHP--;
        healthBar.SetHealth(currentHP);
        if (currentHP <= 0)
        {
            Die();
        }
        return true;
    }
    private void Die()
    {
        Destroy(gameObject);
    }

}
