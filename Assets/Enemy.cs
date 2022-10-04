using UnityEngine;

public class Enemy : MonoBehaviour, ITakeDamage
{
    public GameObject shotPrefab;

    public void Shoot()
    {
        GameObject projectile = ProjectilePool.Instance.GetProjectile();
        projectile.transform.position = transform.position;
        projectile.transform.up = -transform.up;
        projectile.tag = "EnemyProjectile";
    }

    public bool TakeDamage(string fromTag)
    {
        if (fromTag == "PlayerProjectile")
        {
            Destroy(gameObject);
            return true;
        }
        return false;
    }
}
