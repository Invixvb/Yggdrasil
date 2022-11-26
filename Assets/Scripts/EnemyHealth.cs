using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth;
    public float enemyMaxHealth;
    
    public int hitDamageBeer = 35;
    public int hitDamageStekel = 20;
    public int hitDamageWolf = 5;
    public int hitDamageHert = 10;

    public Slider slider;

	private void Start()
    {
        enemyHealth = enemyMaxHealth;
        slider.value = CalculateEnemyHealth();
    }

    private void Update()
    {
        slider.value = CalculateEnemyHealth();

        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }

        if(enemyHealth > enemyMaxHealth)
        {
            enemyHealth = enemyMaxHealth;
        }
    }

    float CalculateEnemyHealth()
    {
        return enemyHealth / enemyMaxHealth;
    }

    public void HitTargetBeer()
	{
        enemyHealth = enemyHealth - hitDamageBeer;
    }

    public void HitTargetStekel()
    {
        enemyHealth = enemyHealth - hitDamageStekel;
    }

    public void HitTargetWolf()
    {
        enemyHealth = enemyHealth - hitDamageWolf;
    }

    public void HitTargetHert()
    {
        enemyHealth = enemyHealth - hitDamageHert;
    }
}
