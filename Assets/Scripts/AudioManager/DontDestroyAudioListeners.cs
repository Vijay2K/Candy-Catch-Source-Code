using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudioListeners : MonoBehaviour
{
    private static DontDestroyAudioListeners Instance;

    private void Awake() {
        if(Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
}
