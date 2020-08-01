using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet_prefab;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bullet_prefab, transform.position, Quaternion.identity);
        }
    }
}
