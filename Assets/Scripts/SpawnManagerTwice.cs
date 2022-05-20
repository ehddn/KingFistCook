using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerTwice : MonoBehaviour
{
    public bool enableSpawn = false;
    public float leftMax;
    public float rightMax;
    public GameObject spot;
    public GameObject spot2;
    public GameObject handlebar;
    public float YPos;

    public void SpawnSpotTwice()
    {
        float randomX = Random.Range(leftMax, (rightMax-leftMax)/2);
        float randomX2 = Random.Range((rightMax - leftMax) / 2, rightMax);
        if (enableSpawn)
        {
            GameObject RandomSpot = (GameObject)Instantiate(spot, new Vector2(randomX, YPos), Quaternion.identity) as GameObject;
            RandomSpot.transform.parent = GameObject.Find("Sliding Area").transform;

            GameObject RandomSpot2 = (GameObject)Instantiate(spot2, new Vector2(randomX2, YPos), Quaternion.identity) as GameObject;
            RandomSpot2.transform.parent = GameObject.Find("Sliding Area").transform;
        }
    }
    private void Awake()
    {
        handlebar = GameObject.FindGameObjectWithTag("Handle");
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnSpotTwice();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
