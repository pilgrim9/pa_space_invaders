using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public LayerMask playerProjectileMask;
    private void Update()
    {
        Move(Input.GetAxis("Horizontal"));
    }

    void Move(float x)
    {
        transform.Translate(Time.deltaTime * speed * new Vector3(x, 0, 0));
    }
    
    void Shoot()
    {
        GameObject projectile = ProjectilePool.Instance.GetProjectile();
        projectile.transform.position = transform.position;
        projectile.transform.rotation = transform.rotation;
        projectile.layer = playerProjectileMask;
        projectile.tag = "PlayerProjectile";
    }
}
