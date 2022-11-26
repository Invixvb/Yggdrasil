using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcefieldPlacing : MonoBehaviour
{
	public static ForcefieldPlacing Instance { get; private set; }
	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	public GameObject[] Forcefields;

	public List<GameObject> placeStagTowers = new List<GameObject>();

	//forcefield empties enabelen wanneer er een hert totem word geplaatsts. If(herttomet nr 3 word geplaats dan zet de empties aan)

	private void Update()
	{
		if (placeStagTowers[0] != null)
		{
			Forcefields[0].SetActive(true);
		}

		if (placeStagTowers[1] != null)
		{
			Forcefields[1].SetActive(true);
		}

		if (placeStagTowers[2] != null)
		{
			Forcefields[2].SetActive(true);
		}

		if (placeStagTowers[3] != null)
		{
			Forcefields[3].SetActive(true);
		}

		if (placeStagTowers[4] != null)
		{
			Forcefields[4].SetActive(true);
		}

		if (placeStagTowers[5] != null)
		{
			Forcefields[5].SetActive(true);
		}

		if (placeStagTowers[6] != null)
		{
			Forcefields[6].SetActive(true);
		}
	}
}