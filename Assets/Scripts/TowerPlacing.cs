using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlacing : MonoBehaviour
{
    public GameObject TotemMenuUI;
	
	[SerializeField] bool MenuIsActive = false;

    public GameObject Beer;
    public GameObject Hert;
    public GameObject Stekelvarken;
    public GameObject Wolf;

    public GameObject TotemFirstButton;

    bool PlayerInTrigger = false;

    public GameObject[] Towerplacements;

    private void Start()
	{
        TotemMenuUI.SetActive(false);
	}

    private void Update()
    {

        if (Input.GetButtonDown("TabMenu") && PlayerInTrigger == true)
        {
            TotemMenuUI.SetActive(true);
            MenuIsActive = !MenuIsActive;

            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(TotemFirstButton);
        }
    }

    public void BearTotem()
    {
        Instantiate(Beer, transform.position, Quaternion.identity);
        TotemMenuUI.SetActive(false);
        MenuIsActive = !MenuIsActive;
        Destroy(gameObject);
    }

    public void StagTotem()
    { 
        GameObject newStag = (GameObject)Instantiate(Hert, transform.position, Quaternion.identity);
        TotemMenuUI.SetActive(false);
        MenuIsActive = !MenuIsActive;
        Destroy(gameObject);
        ForcefieldPlacing.Instance.placeStagTowers.Add(newStag);
    }

    public void PorcupineTotem()
    {
        Instantiate(Stekelvarken, transform.position, Quaternion.identity);
        TotemMenuUI.SetActive(false);
        MenuIsActive = !MenuIsActive;
        Destroy(gameObject);
    }

    public void WolfTotem()
    {
        Instantiate(Wolf, transform.position, Quaternion.identity);
        TotemMenuUI.SetActive(false);
        MenuIsActive = !MenuIsActive;
        Destroy(gameObject); 
    }
      
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == ("Player"))
        {
            PlayerInTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.tag == ("Player"))
        {
            PlayerInTrigger = false;
            if(MenuIsActive == true)
			{
                TotemMenuUI.SetActive(false);
                MenuIsActive = false;
			}
        }
    }
}
