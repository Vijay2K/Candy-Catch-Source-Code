using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [SerializeField] private AudioClip popSound = null;
    [SerializeField] private AudioClip BombSound = null;
    [SerializeField] private AudioClip damageSound = null;

    private void Awake() {
        if(Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public AudioClip GetPopSound() {
        return popSound;
    }

    public AudioClip GetBombSound() {
        return BombSound;
    }

    public AudioClip GetDamageSound() {
        return damageSound;
    }

}
