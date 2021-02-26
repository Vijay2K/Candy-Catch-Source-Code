using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] candies = null;
    [SerializeField] private float maxPos = 1f;

    private void Start() {
        InvokeSpawner();
    }

    public void InvokeSpawner() {
        InvokeRepeating("SpawnCandy", 0.75f, 1.5f);
    }

    private void SpawnCandy() {
        int randomCandies = Random.Range(0, candies.Length);
        float rand = Random.Range(-maxPos, maxPos);

        Vector3 randomPos = new Vector3(rand, transform.position.y, transform.position.z);

        Instantiate(candies[randomCandies], randomPos, Quaternion.identity);

    }

    public void StopSpawning() {
        CancelInvoke("SpawnCandy");
    }
}
