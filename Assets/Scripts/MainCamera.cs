using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject _main_player;

    private Vector3 _position;

    private void Start()
    {
        if (_main_player != null)
        {
            _position = transform.position;
            _position.x = _main_player.transform.position.x;
        }
    }

    public void Update()
    {
        if (_main_player != null)
        {
            _position.x = _main_player.transform.position.x;
            transform.position = Vector3.Lerp(transform.position, _position, Time.deltaTime);
        }
    }
}
