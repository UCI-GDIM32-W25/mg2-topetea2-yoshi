using System.Collections;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float minTime = 0.8f;
    public float maxTime = 1.6f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    // Update is called once per frame
    IEnumerator SpawnCoins()
    {
        while (true)
        {
            float waitTime = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(waitTime);

            Vector3 spawnPos = new Vector3(10f, Random.Range(1f, 3f), 0);
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }
    }
}
