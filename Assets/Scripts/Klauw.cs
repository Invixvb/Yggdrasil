using UnityEngine;

public class Klauw : MonoBehaviour
{
	private Transform target;

	public float speed;

	EnemyHealth eHealth;

	public void Seek(Transform _target)
	{
		target = _target;
	}

	private void Start()
	{
		eHealth = target.GetComponent<EnemyHealth>();
	}

	private void Update()
	{
		if(target == null)
		{
			Destroy(gameObject);
			return;
		}

		Vector3 dir = target.position - transform.position;

		float distanceThisFrame = speed * Time.deltaTime;

		if(dir.magnitude <= distanceThisFrame)
		{
			eHealth.HitTargetBeer();
			Destroy(gameObject);
			return;
		}

		transform.Translate(dir.normalized * distanceThisFrame, Space.World);
	}
}
