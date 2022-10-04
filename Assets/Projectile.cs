using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Time.deltaTime * transform.up);
    }

    private void OnTriggerEnter(Collider other)
    {
        bool tookDamage = other.GetComponent<ITakeDamage>().TakeDamage(gameObject.tag);
        if (tookDamage) ProjectilePool.Instance.EnqueueOne(gameObject);
    }
}
