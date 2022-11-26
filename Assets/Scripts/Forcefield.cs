using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Forcefield : MonoBehaviour
{
	private EnemyHealth eHealth;

	private NavMeshAgent agent;

	public List<GameObject> enemiesFF = new List<GameObject>();

	private void Start()
	{
		eHealth = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyHealth>();
	}

	private void DamageEnemy()
	{
		StartCoroutine(DamageOverTime());
		agent = waveSpawner.Instance.newGO.GetComponent<NavMeshAgent>();
		agent.speed = 3.5f;
	}

	private void SetValuesNormal()
	{
		agent.speed = 7f;
		StopAllCoroutines();
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Enemy")
		{
			enemiesFF.Add(waveSpawner.Instance.newGO);

			if (enemiesFF.Contains(waveSpawner.Instance.newGO))
			{
				DamageEnemy();
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Enemy")
		{
			if (enemiesFF.Contains(waveSpawner.Instance.newGO))
			{
				SetValuesNormal();
				enemiesFF.Remove(waveSpawner.Instance.newGO);
			}
		}
	}

	IEnumerator DamageOverTime()
	{
		yield return new WaitForSeconds(1f);
		StartCoroutine(DamageOverTime());
		eHealth.HitTargetHert();
	}
}
