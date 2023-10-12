using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fire Projectile")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.tag == "Normal Projectile")
            Destroy(other.gameObject);

    }
}
