using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float damage = 2f;
    private float speed = 20f;

    public void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();

        if (health)
        {
            if (!health.applyDamage(damage))
            {
                Destroy(collision.gameObject);
            }
        }

        Destroy(gameObject);
    }
}
