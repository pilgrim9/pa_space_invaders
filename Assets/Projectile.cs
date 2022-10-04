using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    private void Update()
    {
        transform.Translate(speed* Time.deltaTime * transform.up );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DestroyProjectileZone"))
        { 
            ProjectilePool.Instance.ReturnToPool(gameObject);
            return;
        } 
        bool tookDamage = other.GetComponent<ITakeDamage>().TakeDamage(gameObject.tag);
        if (tookDamage) ProjectilePool.Instance.ReturnToPool(gameObject);
    }
}
