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
    
    public Transform enemyParent;
    private int random;

    void Start()
    {
        StartCoroutine(RandomSpawn());
    }

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
                    GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                    obj.transform.SetParent(enemyParent);
                    GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                    objU.transform.SetParent(enemyParent);
                    break;
                case 1:
                    GameObject obj1 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                    obj1.transform.SetParent(enemyParent);
                    GameObject objU1 =PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                    objU1.transform.SetParent(enemyParent);
                    break;
                case 2:
                    GameObject obj2 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                    obj2.transform.SetParent(enemyParent);
                    GameObject objU2 = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                    objU2.transform.SetParent(enemyParent);
                    break;
                case 3:
                    GameObject obj3 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                    obj3.transform.SetParent(enemyParent);
                    GameObject objU3 = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                    objU3.transform.SetParent(enemyParent);
                    break;
                case 4:
                    GameObject obj4 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                    obj4.transform.SetParent(enemyParent);
                    GameObject objU4 = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                    objU4.transform.SetParent(enemyParent);
                    break;
                case 5:
                    GameObject obj5 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1.5f, transform.position.y), Quaternion.identity);
                    obj5.transform.SetParent(enemyParent);
                    GameObject objU5 = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 1.5f, transform.position.y), Quaternion.identity);
                    objU5.transform.SetParent(enemyParent);
                    break;
            }
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        }
    }
}
