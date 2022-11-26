using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TreeHealth : MonoBehaviour
{
    public GameObject GameOverUI;
    public GameObject mainMenufirstButton;
    public static TreeHealth Instance { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public float treeHealth;
    public float treeMaxHealth;

    public Slider slider;

    private void Start()
    {
        treeHealth = treeMaxHealth;
        slider.value = CalculateTreeHealth();
    }

    private void Update()
    {
        slider.value = CalculateTreeHealth();

        if (treeHealth <= 0)
        {
            Destroy(gameObject);
            GameOverUI.active = true;

            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(mainMenufirstButton);

            Time.timeScale = 0f;

        }

        if (treeHealth > treeMaxHealth)
        {
            treeHealth = treeMaxHealth;
        }
    }

    float CalculateTreeHealth()
    {
        return treeHealth / treeMaxHealth;
    }
}
