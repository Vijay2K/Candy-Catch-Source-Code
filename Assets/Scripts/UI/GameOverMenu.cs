using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel = null;

    private Health health;

    public GameObject GetGameOverPanel() {
        return gameOverPanel;
    }

    private void Start() {
        health = GameObject.FindWithTag("Player").GetComponent<Health>();
    }

    private void Update() {
        if (health.GameOver()) {
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
