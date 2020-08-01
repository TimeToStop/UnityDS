using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MainCharacterController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;
    [SerializeField]
    private float _jump_force = 10f;

    [SerializeField]
    private string _ground_tag_name;

    private bool _is_grounded;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        float input_x = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * input_x * Time.deltaTime * _speed);

        if (Input.GetKeyDown(KeyCode.Space) && _is_grounded)
        {
            _is_grounded = false;
            _rigidbody.AddForce(Vector2.up * _jump_force, ForceMode2D.Impulse);
        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals(_ground_tag_name))
        {
            _is_grounded = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals(_ground_tag_name))
        {
            _is_grounded = false;
        }
    }
}
