using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class Sword : MonoBehaviour
{
    public bool _is_hitting => (_animation >= 0);
    [SerializeField]
    private int _animation_count = 10;
    private int _animation = -1;

    [SerializeField]
    private float _hit_damage = 3f;
    
    private Renderer _render;
    private BoxCollider2D _collider;

    private void Start()
    {
        _render = GetComponent<Renderer>();
        _render.enabled = false;

        _collider = GetComponent<BoxCollider2D>();
        _collider.enabled = false;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1) && _animation == -1)
        {
            _animation = _animation_count;
            _render.enabled = true;
            _collider.enabled = true;
        }

        if (_animation >= 0)
        {
            if (_animation == 0)
            {
                _render.enabled = false;
                _collider.enabled = false;
            }

            _animation -= 1;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();

        if (health)
        {
            if (!health.applyDamage(_hit_damage))
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
