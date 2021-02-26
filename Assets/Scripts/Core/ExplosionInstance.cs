using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionInstance : MonoBehaviour
{
    [SerializeField] private GameObject explosion = null;

    public void InstansiateExplosion() {
        GameObject explosionInstance = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(explosionInstance, 0.25f);
    }
}
