using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HomeScreenHighScore : MonoBehaviour
{
    [SerializeField] private TMP_Text highScore = null;

    private void Start() {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
