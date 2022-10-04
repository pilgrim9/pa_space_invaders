using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ProjectilePool : MonoBehaviour
{
    public static ProjectilePool Instance;
    public GameObject projectilePrefab;
    private Queue<GameObject> projectilePool;
    public int poolSize = 10;

    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        projectilePool = new Queue<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            AddNewProjectile();
        }
    }

    void AddNewProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab);
        ReturnToPool(projectile);
    }
    public void ReturnToPool(GameObject projectile)
    {
        projectile.SetActive(false);
        projectilePool.Enqueue(projectile);
    }
    public GameObject GetProjectile()
    {
        GameObject projectile = projectilePool.Dequeue();
        projectile.SetActive(true);
        return projectile;
    }

}
