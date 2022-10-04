using UnityEngine;
using UnityEngine.Events;
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

    public UnityEvent onTakeDamage;
    public bool TakeDamage(string fromTag)
    {
        if (fromTag != "Enemy" && fromTag != "EnemyProjectile") return false;
        currentHP--;
        healthBar.SetHealth(currentHP);
        onTakeDamage.Invoke();
        if (currentHP <= 0)
        {
            Die();
        }
        return true;
    }
    public UnityEvent onDie;
    private void Die()
    {
        onDie.Invoke();
        Destroy(gameObject);
    }

}
