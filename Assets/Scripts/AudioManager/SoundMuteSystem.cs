using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundMuteSystem : MonoBehaviour
{
    [SerializeField] private Button soundToggleButton = null;
    [SerializeField] private Sprite onButton = null;
    [SerializeField] private Sprite offButton = null;

    private void Start() {
        UpdateButtonIcon();
    }

    private void ToggleSound() {
        if(PlayerPrefs.GetInt("Muted", 0) == 0) {
            PlayerPrefs.SetInt("Muted", 1);
        } else {
            PlayerPrefs.SetInt("Muted", 0);
        }
    }

    private void UpdateButtonIcon() {
        if(PlayerPrefs.GetInt("Muted", 0) == 0) {
            AudioListener.volume = 1;
            soundToggleButton.GetComponent<Image>().sprite = onButton;
        } else {
            AudioListener.volume = 0;
            soundToggleButton.GetComponent<Image>().sprite = offButton;
        }
    }

    public void PauseMusic() {
        ToggleSound();
        UpdateButtonIcon();
    }

}
