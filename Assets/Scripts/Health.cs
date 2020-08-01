using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float value = 10f;


    // Return: is alive
    public bool applyDamage(float damage)
    {
        value -= damage;
        return value >= 0;
    }
}
