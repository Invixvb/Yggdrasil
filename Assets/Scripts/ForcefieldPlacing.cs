using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcefieldPlacing : MonoBehaviour
{
	public GameObject[] forceFields;
	public List<GameObject> placeStagTowers = new();
	
	public static ForcefieldPlacing Instance { get; private set; }
	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	private void Update()
	{
		CheckForceFieldEmpty();
	}

	private void CheckForceFieldEmpty()
	{
		if (placeStagTowers.Count != 0)
		{
			if (placeStagTowers[0] != null)
			{
				forceFields[0].SetActive(true);
			}
			else if (placeStagTowers[1] != null)
			{
				forceFields[1].SetActive(true);
			}
			else if (placeStagTowers[2] != null)
			{
				forceFields[2].SetActive(true);
			}
			else if (placeStagTowers[3] != null)
			{
				forceFields[3].SetActive(true);
			}
			else if (placeStagTowers[4] != null)
			{
				forceFields[4].SetActive(true);
			}
			else if (placeStagTowers[5] != null)
			{
				forceFields[5].SetActive(true);
			}
			else if (placeStagTowers[6] != null)
			{
				forceFields[6].SetActive(true);
			}
		}
	}
}