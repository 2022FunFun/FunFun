using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private bool check1 = true;
    private bool check2 = true;

    [SerializeField] int stage;

    public GameObject sprite;

    void Awake()
    {
        if (stage == 0)
            StartCoroutine(Stage0Spawn());
        if(stage == 1)
        StartCoroutine(Stage1Spawn());

        if(stage == 2)
        StartCoroutine(Stage2Spawn());
        
        if(stage == 3)
        StartCoroutine(Stage3Spawn());

        check1 = true;
        check2 = true;
    }

    void Update()
    {
        if (leftenemy + leftUFOenemy <= 0)
        {
            StartCoroutine(Die());
            
        }
    }

    public IEnumerator Die()
    {
        sprite.SetActive(true);
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1;
        Destroy(gameObject);
        SceneManager.LoadScene("First");
    }


    IEnumerator Stage0Spawn()
    {
        leftenemy = 9;
        leftUFOenemy = 1;
        yield return new WaitForSeconds(3f);
        while (leftenemy > 0)
        {
            random = Random.Range(0, 5);
            switch (random)
            {
                case 0:
                    GameObject obj0 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                    obj0.transform.SetParent(enemyParent);
                    break;
                case 1:
                    GameObject obj1 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1, transform.position.y), Quaternion.identity);
                    obj1.transform.SetParent(enemyParent);
                    break;
                case 2:
                    GameObject obj2 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 2, transform.position.y), Quaternion.identity);
                    obj2.transform.SetParent(enemyParent);
                    break;
                case 3:
                    GameObject obj3 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 1, transform.position.y), Quaternion.identity);
                    obj3.transform.SetParent(enemyParent);
                    break;
                case 4:
                    GameObject obj4 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 2, transform.position.y), Quaternion.identity);
                    obj4.transform.SetParent(enemyParent);
                    break;
            }
            yield return new WaitForSeconds(4f);
        }
        GameObject obj = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
        obj.transform.SetParent(enemyParent);
        yield return null;
    }
    IEnumerator Stage1Spawn()
    {
        delay = 2f;
        leftenemy = 20;
        leftUFOenemy = 6;
        yield return new WaitForSeconds(1.5f);

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
                delay = 1.8f;
            if (leftenemy + leftUFOenemy < 30)
                delay = 1.6f;
            if (leftenemy + leftUFOenemy < 20)
                delay = 1.4f;
            if (leftenemy + leftUFOenemy < 15)
                delay = 1.2f;
            if (leftenemy + leftUFOenemy < 10)
                delay = 1f;

            if (leftenemy + leftUFOenemy <= 0)
            {
                SceneManager.LoadScene("First");
            }
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator Stage2Spawn()
    {
        delay = 2.8f;
        leftenemy = 43;
        leftUFOenemy = 10;
        yield return new WaitForSeconds(1.5f);

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
                delay = 2.6f;
            if (leftenemy + leftUFOenemy < 40)
                delay = 2.4f;
            if (leftenemy + leftUFOenemy < 30)
                delay = 2.2f;
            if (leftenemy + leftUFOenemy < 20)
                delay = 2f;
            if (leftenemy + leftUFOenemy < 15)
                delay = 1.8f;
            if (leftenemy + leftUFOenemy < 10)
                delay = 1.5f;

            if (leftenemy + leftUFOenemy <= 0)
            {
                SceneManager.LoadScene("First");
            }
            yield return new WaitForSeconds(Random.Range(delay-1,delay));
        }
    }

    IEnumerator Stage3Spawn()
    {
        delay = 2f;
        leftenemy = 46;
        leftUFOenemy = 20;
        yield return new WaitForSeconds(1.5f);

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
                delay = 1.9f;
            if (leftenemy + leftUFOenemy < 50)
            {
                delay = 1.8f;
                if(check1)
                {
                    GameObject obj = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                    obj.transform.SetParent(enemyParent);
                    GameObject obj1 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 1, transform.position.y), Quaternion.identity);
                    obj1.transform.SetParent(enemyParent);
                    GameObject obj2 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 1, transform.position.y), Quaternion.identity);
                    obj2.transform.SetParent(enemyParent);
                    GameObject obj3 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x + 2, transform.position.y), Quaternion.identity);
                    obj3.transform.SetParent(enemyParent);
                    GameObject obj4 = PoolManager.Instance.Pop(enemyPrefab, new Vector2(transform.localPosition.x - 2, transform.position.y), Quaternion.identity);
                    obj4.transform.SetParent(enemyParent);
                    check1 = false;
                }
            }
            if (leftenemy + leftUFOenemy < 40)
                delay = 1.6f;
            if (leftenemy + leftUFOenemy < 30)
            {
                delay = 1.5f;
                if(check2)
                {
                    GameObject obj = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x, transform.position.y), Quaternion.identity);
                    obj.transform.SetParent(enemyParent);
                    GameObject obj1 = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 1, transform.position.y), Quaternion.identity);
                    obj1.transform.SetParent(enemyParent);
                    GameObject obj2 = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x + 2, transform.position.y), Quaternion.identity);
                    obj2.transform.SetParent(enemyParent);
                    GameObject obj3 = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 1, transform.position.y), Quaternion.identity);
                    obj3.transform.SetParent(enemyParent);
                    GameObject obj4 = PoolManager.Instance.Pop(UFOenemyPrefab, new Vector2(transform.localPosition.x - 2, transform.position.y), Quaternion.identity);
                    obj4.transform.SetParent(enemyParent);
                    check2 = false;
                }
            }
            if (leftenemy + leftUFOenemy < 20)
                delay = 1.3f;
            if (leftenemy + leftUFOenemy < 15)
                delay = 1.2f;
            if (leftenemy + leftUFOenemy < 10)
                delay = 1f;

            if (leftenemy + leftUFOenemy <= 0)
            {
                SceneManager.LoadScene("First");
            }
            yield return new WaitForSeconds(Random.Range(delay - 1, delay));
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
