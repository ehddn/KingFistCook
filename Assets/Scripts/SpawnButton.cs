using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SpawnButton : MonoBehaviour
{
    public float MinX;
    public float MinY;
    public float MaxX;
    public float MaxY;

    public int SpawnCount = 5;

    public AudioSource musicPlayer;
    public AudioClip bgm;

    public GameObject bt;

    public void RandomSpawn()
    {
        float randomX = Random.Range(MinX, MaxX);
        float randomY = Random.Range(MinY, MaxY);
            GameObject RandomBtn = (GameObject)Instantiate(bt, new Vector2(randomX, randomY), Quaternion.identity) as GameObject;
            RandomBtn.transform.parent = GameObject.Find("Canvas").transform;
            


        
    }
    IEnumerator delaySpawn()
    {
        yield return new WaitForSeconds(2f);
        musicPlayer.Play();
        RandomSpawn();

    }
        // Start is called before the first frame update
        void Start()
        {
        musicPlayer = GetComponent<AudioSource>();
        
        
        for (int i = 0; i < 5; i++)
        {
            StartCoroutine("delaySpawn");
        }
             
            
        }
        
        // Update is called once per frame
        void Update()
        {
        
        }

    
}

