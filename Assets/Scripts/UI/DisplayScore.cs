using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTextUI = null;
    [SerializeField] private TMP_Text gameOverPanelScoreUI = null;
    [SerializeField] private TMP_Text hightScoreTextUI = null;

    private DisplayXP displayXP;
    private Health health;
    private int score = 0;

    private void Start() {
        displayXP = GameObject.Find("DisplayXPs").GetComponent<DisplayXP>();
        health = GameObject.FindWithTag("Player").GetComponent<Health>();
    }

    private void Update() {
        if (health.GameOver()) {
            hightScoreTextUI.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }

    public void UpdateScoreUI() {
        score++;
        scoreTextUI.text = score.ToString();
        gameOverPanelScoreUI.text = score.ToString();
        if(score % 5 == 0) {
            if(score == 0) { return; }
            displayXP.XPDisplay();
        }

        if(score > PlayerPrefs.GetInt("HighScore", 0)) {
            PlayerPrefs.SetInt("HighScore", score);
        }

    }
}
