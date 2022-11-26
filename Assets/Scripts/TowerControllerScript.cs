using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerControllerScript : MonoBehaviour
{
    public GameObject Player;

    public GameObject camera1;
    public GameObject camera2;
    [SerializeField] bool standardCamera = true;

    public Transform TPOne;
    public Transform TPTwo;
    public Transform TPThree;
    public Transform TPFour;
    public Transform TPFive;

    public GameObject TP_UI;

    public GameObject TPfirstbutton;

   

    bool topdown;
 
    bool triggerStay = false;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "Player")
        {
            triggerStay = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        triggerStay = false;
    }


    public void Update()
    {
        if (Input.GetButtonDown("CamChange") && triggerStay == true && topdown == false)
        {
           
            camera1.active = !camera1.active;
            camera2.active = !camera2.active;
            topdown = true;
            TP_UI.SetActive(true);
            Player.GetComponent<playerMovement>().enabled = false;

            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(TPfirstbutton);
           
        }

    }

    void ChangeCamera()
    {
        if (camera1.active)
        {
            camera2.active = !camera2.active;
            topdown = false;
        }

        else if (camera2.active)
        {
            camera1.active = !camera1.active;
            topdown = true;
        }
    }


    public void TP1()
    {
        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        Player.transform.position = TPOne.transform.position;
        camera1.active = standardCamera;
        ChangeCamera();
        topdown = false;
       

    }
    public void TP2()
    {

        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        Player.transform.position = TPTwo.transform.position;
        camera1.active = standardCamera;
        ChangeCamera();
        topdown = false;
        
    }
    public void TP3()
    {
        Player.transform.position = TPThree.transform.position;
        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        camera1.active = standardCamera;
        ChangeCamera();
        topdown = false;
        
    }
    public void TP4()
    {
        Player.transform.position = TPFour.transform.position;
        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        camera1.active = standardCamera;
        ChangeCamera();
        topdown = false;
        
    }
    public void TP5()
    {
        Player.transform.position = TPFive.transform.position;
        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        camera1.active = standardCamera;
        ChangeCamera();
        topdown = false;
        
    }
}
