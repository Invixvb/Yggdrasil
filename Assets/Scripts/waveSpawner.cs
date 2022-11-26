using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waveSpawner : MonoBehaviour
{
    public static waveSpawner Instance { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    [Header("References")]
    public GameObject MMUI;
    public GameObject WaveCountDownTimer;
    public Text wavecountdownText;
    public Text waveText;
    public GameObject enemyPrefab;
    public Transform SpawnPoint;

    [Header("Input")]
    public float timeBetweenWaves;

    private float countdown = 10f;
    private int waveIndex = 0;

    public List<GameObject> enemies = new List<GameObject>();

    [HideInInspector]public GameObject newGO;

    void Update()
    {
        if (MMUI.active == false)
        {
            WaveCountDownTimer.SetActive(true);

            countdown -= Time.deltaTime;
            if (countdown <= 0f)
            {
	            StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
            }
            wavecountdownText.text = Mathf.Round(countdown).ToString();
        }
        else return;
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            waveText.text = waveIndex.ToString();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy()
    {
        newGO = Instantiate(enemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
        enemies.Add(newGO);
    }
}