using UnityEngine;
public class HealthBar : MonoBehaviour
{
    public void SetHealth(float health)
    {
        transform.localScale = new Vector3(health, 1f);
    }
}
