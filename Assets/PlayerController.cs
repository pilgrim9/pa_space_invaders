using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float shotCooldown = 0.5f;
    private bool canShoot = true;
    private void Update()
    {
        Move(Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Move(float x)
    {
        transform.Translate(Time.deltaTime * speed * new Vector3(x, 0, 0));
    }
    
    void Shoot()
    {
        if (!canShoot) return;
        StartCoroutine(nameof(ShootCooldown));
        GameObject projectile = ProjectilePool.Instance.GetProjectile();
        projectile.transform.position = transform.position;
        projectile.transform.rotation = transform.rotation;
        projectile.tag = "PlayerProjectile";
    }
    IEnumerator ShootCooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(shotCooldown);
        canShoot = true;
    }
}
