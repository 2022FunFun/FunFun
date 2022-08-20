using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    public int leftenemy = 0;
    [SerializeField] GameObject UFOenemyPrefab;
    public int leftUFOenemy = 0;

    public int totalEnemy = 0;

    [SerializeField] Transform enemyTransform;

    public Transform enemyParent;
    private int random;
    private int randomSpawn;
    private float delay = 0f;

    [SerializeField] int stage;

    void Start()
    {
        if(stage == 1)
        StartCoroutine(Stage1Spawn());

        if(stage == 2)
        StartCoroutine(Stage2Spawn());
        
        if(stage == 3)
        StartCoroutine(Stage3Spawn());
    }

    IEnumerator Stage1Spawn()
    {
        yield return new WaitForSeconds(1.5f);
        delay = 4f;
        leftenemy = 40;
        leftUFOenemy = 7;

        totalEnemy = leftenemy + leftUFOenemy;
        while (true)
        {
            random = Random.Range(0, 5);
            switch (random)
            {
                case 0:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 1:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 2:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 3:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 4:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
            }
            if (leftenemy + leftUFOenemy < 40)
                delay = 3.5f;
            if (leftenemy + leftUFOenemy < 30)
                delay = 3f;
            if (leftenemy + leftUFOenemy < 20)
                delay = 2.5f;
            if (leftenemy + leftUFOenemy < 15)
                delay = 2f;
            if (leftenemy + leftUFOenemy < 10)
                delay = 1.5f;
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator Stage2Spawn()
    {
        yield return new WaitForSeconds(1.5f);
        delay = 4f;
        leftenemy = 43;
        leftUFOenemy = 10;

        totalEnemy = leftenemy + leftUFOenemy;
        while (true)
        {
            random = Random.Range(0, 5);
            switch (random)
            {
                case 0:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 1:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 2:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 3:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 4:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
            }
            if (leftenemy + leftUFOenemy < 50)
                delay = 3.5f;
            if (leftenemy + leftUFOenemy < 40)
                delay = 3f;
            if (leftenemy + leftUFOenemy < 30)
                delay = 2.5f;
            if (leftenemy + leftUFOenemy < 20)
                delay = 2f;
            if (leftenemy + leftUFOenemy < 15)
                delay = 1.5f;
            if (leftenemy + leftUFOenemy < 10)
                delay = 1f;
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator Stage3Spawn()
    {
        yield return new WaitForSeconds(1.5f);
        delay = 4f;
        leftenemy = 50;
        leftUFOenemy = 12;

        totalEnemy = leftenemy + leftUFOenemy;
        while (true)
        {
            random = Random.Range(0, 5);
            switch (random)
            {
                case 0:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 1f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 1:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 2f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 2:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 2f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 3:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1f, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
                case 4:
                    randomSpawn = Random.Range(0, 5);
                    if (randomSpawn == 0)
                    {
                        if (leftUFOenemy <= 0)
                        {
                            GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                            obj.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                        objU.transform.SetParent(enemyParent);
                    }
                    else
                    {
                        if (leftenemy <= 0)
                        {
                            GameObject objU = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                            objU.transform.SetParent(enemyParent);
                            break;
                        }
                        GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                        obj.transform.SetParent(enemyParent);
                    }
                    break;
            }
            if (leftenemy + leftUFOenemy < 55)
                delay = 3.5f;
            if (leftenemy + leftUFOenemy < 50)
                delay = 3f;
            if (leftenemy + leftUFOenemy < 40)
                delay = 2.5f;
            if (leftenemy + leftUFOenemy < 30)
                delay = 2f;
            if (leftenemy + leftUFOenemy < 20)
                delay = 1.5f;
            if (leftenemy + leftUFOenemy < 15)
                delay = 1f;
            if (leftenemy + leftUFOenemy < 10)
                delay = 0.5f;
            yield return new WaitForSeconds(delay);
        }
    }

    public void MinusEnemy()
    {
        leftenemy--;
    }
    public void MinusUFOEnemy()
    {
        leftUFOenemy--;
    }
}
