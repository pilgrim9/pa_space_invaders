using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    private void Update()
    {
        transform.Translate(speed* Time.deltaTime * transform.up );
    }

    private void OnTriggerEnter(Collider other)
    {
        bool tookDamage = other.GetComponent<ITakeDamage>().TakeDamage(gameObject.tag);
        if (tookDamage) ProjectilePool.Instance.EnqueueOne(gameObject);
    }
}
