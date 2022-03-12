using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCalc : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Result : "+SumFactorial(20));
    }

    public List<int> SumFactorial(int num)
    {
        int playerHP = 2;
        List<int> enemies = new List<int>();
        for (int i = 0; i < num; i++)
        {
            int enemyHP = playerHP - 1;
            playerHP += enemyHP;
            enemies.Add(enemyHP);
        }
        return enemies;
    }
}
