using UnityEngine;

public class Waypoints : MonoBehaviour
{
	public Transform[] waypoints;

    public static Waypoints Instance { get; private set; }
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
}