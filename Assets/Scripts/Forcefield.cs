using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Forcefield : MonoBehaviour
{
	private EnemyHealth eHealth;

	private NavMeshAgent agent;

	public List<GameObject> enemiesFf = new();

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
		if(other.CompareTag("Enemy"))
		{
			enemiesFf.Add(waveSpawner.Instance.newGO);

			if (enemiesFf.Contains(waveSpawner.Instance.newGO))
			{
				DamageEnemy();
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Enemy")
		{
			if (enemiesFf.Contains(waveSpawner.Instance.newGO))
			{
				SetValuesNormal();
				enemiesFf.Remove(waveSpawner.Instance.newGO);
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
