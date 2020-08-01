using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.GetComponent<KillBox>())
        {
            Destroy(collision.gameObject);
        }
    }
}
