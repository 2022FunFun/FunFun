using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentEnemy : MonoBehaviour
{
    TextMeshProUGUI score;
    EnemySpawner enemySpawner;
    private void Awake()
    {
        score = GetComponent<TextMeshProUGUI>();
        enemySpawner = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
    }
    void Update()
    {
        score.text = " "+(enemySpawner.leftenemy + enemySpawner.leftUFOenemy);
    }
}