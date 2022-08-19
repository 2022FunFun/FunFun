using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float minSpawnTime;
    [SerializeField] float maxSpawnTime;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject UFOenemyPrefab;
    [SerializeField] Transform enemyTransform;
    private int random;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomSpawn());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator RandomSpawn()
    {
        while (true)
        {
            random = Random.Range(0, 5);
            switch (random)
            {
                case 0:
                    PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.position.x - 1f, transform.position.y), Quaternion.identity);
                    PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.position.x - 1f, transform.position.y), Quaternion.identity);
                    break;
                case 1:
                    PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.position.x - 0.5f, transform.position.y), Quaternion.identity);
                    PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.position.x - 0.5f, transform.position.y), Quaternion.identity);
                    break;
                case 2:
                    PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                    PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                    break;
                case 3:
                    PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.position.x + 0.5f, transform.position.y), Quaternion.identity);
                    PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.position.x + 0.5f, transform.position.y), Quaternion.identity);
                    break;
                case 4:
                    PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.position.x + 1f, transform.position.y), Quaternion.identity);
                    PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.position.x + 1f, transform.position.y), Quaternion.identity);
                    break;
                case 5:
                    PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.position.x + 1.5f, transform.position.y), Quaternion.identity);
                    PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.position.x + 1.5f, transform.position.y), Quaternion.identity);
                    break;
            }
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        }
    }
}
