using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour, ITakeDamage
{
    public GameObject shotPrefab;

    public void Shoot()
    {
        GameObject projectile = ProjectilePool.Instance.GetProjectile();
        projectile.transform.position = transform.position;
        projectile.transform.up = Vector3.right;
        projectile.tag = "EnemyProjectile";
    }

    public UnityEvent onDeath;
    public bool TakeDamage(string fromTag)
    {
        if (fromTag == "PlayerProjectile")
        {
            Destroy(gameObject);
            onDeath.Invoke();
            return true;
        }
        return false;
    }
}
