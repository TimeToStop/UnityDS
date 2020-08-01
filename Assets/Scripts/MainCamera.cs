using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject _main_player;

    private Vector3 position;

    private void Start()
    {
        position = transform.position;
        position.x = _main_player.transform.position.x;
    }

    public void Update()
    {
        position.x = _main_player.transform.position.x;
        transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime);
    }
}
