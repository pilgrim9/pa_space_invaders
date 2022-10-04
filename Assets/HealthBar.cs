using UnityEngine;
public class HealthBar : MonoBehaviour
{

    private float maxHealth;
    public void SetHealth(float health)
    {
        transform.localScale = new Vector3(health/maxHealth, 1f);
    }
    public void SetMaxHealth(float health)
    {
        maxHealth = health;
        transform.localScale = new Vector3(1f, 1f);
    }
}
