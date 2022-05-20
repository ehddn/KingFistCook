using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public float leftMax;
    public float rightMax;
    public GameObject spot;
    public GameObject handlebar;
    public float YPos;
    

    public void SpawnSpot()
    {
        
        float randomX = Random.Range(leftMax, rightMax);
        if (enableSpawn)
        {
            GameObject RandomSpot = (GameObject)Instantiate(spot, new Vector2(randomX, YPos),Quaternion.identity) as GameObject;
            RandomSpot.transform.parent = GameObject.Find("Sliding Area").transform;
            
        }
        
    }
    /*
    public void SpawnSpotTwice()
    {
        float randomX = Random.Range(leftMax, rightMax/2);
        float randomX2 = Random.Range(leftMax / 2, rightMax);
        if (enableSpawn)
        {
            GameObject RandomSpot =(GameObject)Instantiate(spot, new Vector2(randomX, YPos), Quaternion.identity) as GameObject;
            RandomSpot.transform.parent = GameObject.Find("Sliding Area").transform;

            GameObject RandomSpot2 = (GameObject)Instantiate(spot, new Vector2(randomX2, YPos), Quaternion.identity) as GameObject;
            RandomSpot2.transform.parent = GameObject.Find("Sliding Area").transform;
        }
    }*/
    private void Awake()
    {
        handlebar = GameObject.FindGameObjectWithTag("Handle");
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //YPos = GameObject.Find("Scrollbar").transform.position.x;
        SpawnSpot();
        
        //Invoke("SpawnSpot", 1f); 1�� �ڿ� �ϳ� ����
        //InvokeRepeating(func,1,1) //1�ʵڿ� �Լ� ���� �� 1�ʵڿ� �� ���� �ݺ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
