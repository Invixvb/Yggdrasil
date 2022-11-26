using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class MainMenu : MonoBehaviour
{
    public GameObject player;

    public GameObject howtoplay;

    public GameObject MainMenuCamera;
    public GameObject camera1;

    public GameObject MMUI;

    public GameObject TreeLifeUI;

    public bool mainmenuActive;

    public GameObject startButtonfirst;
   

    void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(startButtonfirst);

        TreeLifeUI.SetActive(false);
        camera1.active = false;
        MainMenuCamera.active = true;
    }

    
    void Update()
    {
        if (MainMenuCamera.active)
        {
            
            mainmenuActive = true;
            player.GetComponent<playerMovement>().enabled = false;

        }

        if (camera1.active)
        {
            mainmenuActive = false;
            MMUI.SetActive(false);
            player.GetComponent<playerMovement>().enabled = true;
        }

        if(howtoplay.active == true && Input.GetButtonDown("Cancel"))
        {
            howtoplay.active = false;
        }
       
    }

    public void PlayGame()
    {
        MainMenuCamera.active = false;
        camera1.active = true;
        TreeLifeUI.SetActive(true);
        Time.timeScale = 1f;
    }

    public void HowToPlay()
    {
        howtoplay.active = true;
       
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMainMenu()
	{
        SceneManager.LoadScene("Julian");
	}
}
