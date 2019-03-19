using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public float maxVelocity = 3f;
    public float spawnRate = 1f;
    public float spawnPadding = 2f;

    public void Spawn(GameObject prefab, Vector3 position) {
        Quaternion randomRot = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));

        GameObject asteroid = Instantiate(prefab, position, randomRot, transform);

        Rigidbody2D rigid = asteroid.GetComponent<Rigidbody2D>();
        Vector2 randomForce = Random.insideUnitCircle * maxVelocity;
        rigid.AddForce(randomForce, ForceMode2D.Impulse);
    }

    void SpawnLoop() {
        Vector3 randomPos = Random.insideUnitSphere * spawnPadding;
        int randomIndex = Random.Range(0, asteroidPrefabs.Length);
        GameObject randomAsteroid = asteroidPrefabs[randomIndex];
        Spawn(randomAsteroid, randomPos);
    }
    void Start()
    {
        InvokeRepeating("SpawnLoop", 0, spawnRate);
    }

    public Color debugColor = Color.cyan;

    private void OnDrawGizmos() {
        Gizmos.color = debugColor;
        Gizmos.DrawWireSphere(transform.position, spawnPadding);
    }

    void Update()
    {
        
    }
}
