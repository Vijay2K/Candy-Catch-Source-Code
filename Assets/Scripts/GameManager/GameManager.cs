using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void LoadScenes(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
    }

    public void Quit() {
        Application.Quit();
    }

}
