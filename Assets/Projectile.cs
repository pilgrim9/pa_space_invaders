using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Time.deltaTime * transform.up);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ITakeDamage>().TakeDamage();
        ProjectilePool.Instance.EnqueueOne(gameObject);
    }
}
