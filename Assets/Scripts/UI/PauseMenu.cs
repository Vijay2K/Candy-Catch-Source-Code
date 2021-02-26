using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel = null;
    private static bool isGamePaused = false;

    private void Start() {
        gameOverPanel.SetActive(false);
    }

    private void Update() {
        if (isGamePaused) {
            Paused();
        } else {
            Resume();
        }
    }

    public void Resume() {
        isGamePaused = false;
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Paused() {
        isGamePaused = true;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Leave(int sceneIndex) {
        isGamePaused = false;
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene(sceneIndex);
    }
}
