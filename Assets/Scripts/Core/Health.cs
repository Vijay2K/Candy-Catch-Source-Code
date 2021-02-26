using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static Health Instance;

    [SerializeField] private float healthPoints = 3f;
    [SerializeField] private GameObject heartExplosionParticles = null;
    [SerializeField] private GameObject[] heartSprites = null;

    private CandySpawner candySpawner;
    private bool isGameOver;
    private GameOverMenu gameOverMenu;

    public bool GameOver() {
        return isGameOver;
    }

    private void Awake() {
        if(Instance == null) {
            Instance = this;
        }
    }

    private void Start() {
        isGameOver = false;
        candySpawner = GameObject.Find("CandySpawner").GetComponent<CandySpawner>();
        gameOverMenu = GameObject.Find("UIManager").GetComponent<GameOverMenu>();
    }

    public void DeclineHealth(float decreaseHealth) {
        healthPoints = Mathf.Max(healthPoints - decreaseHealth, 0);
        Debug.Log("Health : " + healthPoints);

        if(healthPoints == 0) {
            isGameOver = true;
            candySpawner.StopSpawning();

            Debug.Log("Game Over, Try Again");
        }

        UpdateHealthUI();
    }

    private void UpdateHealthUI() {
        for(int i = 0; i < heartSprites.Length; i++) {
            if(i < healthPoints) {
                heartSprites[i].SetActive(true);
            } else {
                if(heartSprites[i] == null) { return; }
                InstantiateExplosionParticles(i);
                //Destroy(heartSprites[i]);
                heartSprites[i].SetActive(false);
            }
        }
    }

    private void InstantiateExplosionParticles(int i) {
        if (heartSprites[i].activeSelf) {
            Instantiate(heartExplosionParticles, heartSprites[i].transform.position, transform.rotation);
        }
    }

    public void AddExtraHealth() {
        if (isGameOver && healthPoints == 0) {
            isGameOver = false;
            healthPoints++;
            heartSprites[0].SetActive(true);
            gameOverMenu.GetGameOverPanel().SetActive(false);
            candySpawner.InvokeSpawner();
        }
    }
}
