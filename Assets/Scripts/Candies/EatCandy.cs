using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatCandy : MonoBehaviour
{
    private DisplayScore displayScore;
    private DisplayFloatingText displayFloatingText;
    private Health health;
    private ExplosionInstance explosionInstance;
    private AudioSource audioSource;

    private float damagePoints = 1f;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
        displayScore = GameObject.Find("UIManager").GetComponent<DisplayScore>();
        displayFloatingText = GetComponent<DisplayFloatingText>();
        health = GetComponent<Health>();
        explosionInstance = GetComponent<ExplosionInstance>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "candy") {
            displayScore.UpdateScoreUI();
            audioSource.PlayOneShot(AudioManager.Instance.GetPopSound());
            Destroy(collision.gameObject);
            displayFloatingText.DisplayText();
            
        }
        if(collision.gameObject.tag == "Bomb") {
            audioSource.PlayOneShot(AudioManager.Instance.GetBombSound());
            Destroy(collision.gameObject);
            health.DeclineHealth(damagePoints);
            explosionInstance.InstansiateExplosion();
        }
    }
}
