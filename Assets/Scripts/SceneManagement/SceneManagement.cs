using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{

    [SerializeField] private GameObject loadingScreen = null;
    [SerializeField] private Slider slider = null;

    public void LoadLevel(int sceneIndex) {
        StartCoroutine(LoadAsynchronusly(sceneIndex));
    }

    private IEnumerator LoadAsynchronusly(int sceneIndex) {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone) {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }

    }
}
