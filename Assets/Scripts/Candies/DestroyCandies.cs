using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCandies : MonoBehaviour
{
    [SerializeField] private GameObject candySplash_Particles = null;
    private ExplosionInstance explosionInstance;
    private AudioSource audioSource;

    private Health health;

    private float damage = 1f;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
        health = GameObject.FindWithTag("Player").GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "candy") {
            GameObject candyParticeInstance = Instantiate(candySplash_Particles, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            health.DeclineHealth(damage);
            GameObject.FindWithTag("Player").GetComponent<AudioSource>().PlayOneShot(AudioManager.Instance.GetDamageSound());

            Destroy(candyParticeInstance, 2f);
        }
        if(collision.gameObject.tag == "Bomb") {
            explosionInstance = collision.gameObject.GetComponent<ExplosionInstance>();
            explosionInstance.InstansiateExplosion();
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(AudioManager.Instance.GetBombSound());
        }
    }
}
