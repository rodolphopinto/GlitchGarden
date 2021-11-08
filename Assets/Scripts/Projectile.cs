using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float demage = 50f;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        Health health = otherCollision.GetComponent<Health>();
        Attacker attacker = otherCollision.GetComponent<Attacker>();
        if (health && attacker) {
            health.DealDamage(demage);
            Destroy(gameObject);
        }
    }
}
