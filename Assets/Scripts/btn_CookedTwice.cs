using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_CookedTwice : MonoBehaviour
{
    SpawnManager spawn;
    AudioSource audioSource;
    public float handlePos;
    public float SpotPos;
    public float SpotPos2;

    public int Spot_count;
    public int Spot2_count;

    public int clickcount=2;

    public Image righthand;
    public Image lefthand;
    public Image rightfist;
    public Image leftfist;




    public void Onclicked()
    {
        righthand.gameObject.SetActive(false);
        lefthand.gameObject.SetActive(false);

        GameObject.Find("GameManager").GetComponent<GameManager>().PlayCount++;
        clickcount--;
        if (SpotPos - 70 < handlePos && handlePos < SpotPos + 70)
        {
            Debug.Log("소금 성공");
            audioSource.Play();
            
             
             
                leftfist.gameObject.SetActive(true);
                rightfist.gameObject.SetActive(false);
           
            DestroySpot();
            GameObject.Find("GameManager").GetComponent<GameManager>().score++;
            if (clickcount <= 0)
            {
                DestroySpot2();
                SpawnAgainTwice();
            }

        }
        else if (SpotPos2 - 70< handlePos && handlePos < SpotPos2 + 70)
        {
            Debug.Log("참기름 성공");
            audioSource.Play();
            leftfist.gameObject.SetActive(false);
            rightfist.gameObject.SetActive(true);
            DestroySpot2();
            GameObject.Find("GameManager").GetComponent<GameManager>().score++;
            if (clickcount <= 0)
            {
                DestroySpot();
                SpawnAgainTwice();
            }
        }
        else
        {
            if (clickcount <= 0)
            {
                DestroySpot();
                DestroySpot2();

                Invoke("SpawnAgainTwice", 2f);
            }
        }
        
         
     
        

        
    }

    // Start is called before the first frame update
    void SpawnAgainTwice()
    {
        GameObject.Find("SpawnManager").GetComponent<SpawnManagerTwice>().SpawnSpotTwice();
        GetSpotPos();
        clickcount = 2;
    }
    void GetSpotPos()
    {
        SpotPos = GameObject.FindGameObjectWithTag("Spot").transform.position.x;
        SpotPos2 = GameObject.FindGameObjectWithTag("Spot2").transform.position.x;
    }
    
    private void DestroySpot()
    {
        Destroy(GameObject.FindGameObjectWithTag("Spot"));
        
    }
    private void DestroySpot2()
    {
        Destroy(GameObject.FindGameObjectWithTag("Spot2"));
    }
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        handlePos = GameObject.FindGameObjectWithTag("Handle").transform.position.x;
        Invoke("GetSpotPos", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        handlePos = GameObject.FindGameObjectWithTag("Handle").transform.position.x;
    }
}
