using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class btn_Cooked : MonoBehaviour
{
    SpawnManager spawn;
    AudioSource audioSource;


    public float handlePos;
    public float SpotPos;

    public Image im_1;
    public Image im_2;
    public Image im_3;
    public Image im_4;
    public Image im_5;
    public Image im_6;


    public Image righthand;
    public Image lefthand;
    public Image rightfist;
    public Image leftfist;

    public Image Bob_1;
    public Image Bob_2;
    public Image Bob_3;
    




    private int TurnHand=1;

    private int count = 0;

    //public string scene;



    public void Onclicked()
    {
        righthand.gameObject.SetActive(false);
        lefthand.gameObject.SetActive(false);

        GameObject.Find("GameManager").GetComponent<GameManager>().PlayCount++;
        if (SpotPos - 150 < handlePos && handlePos < SpotPos + 150)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().score++;
            Debug.Log("성공");
            
            audioSource.Play();
            if (TurnHand == 1)
            {
                rightfist.gameObject.SetActive(true);
                leftfist.gameObject.SetActive(false);
                TurnHand *= -1;
            }
            else
            {
                leftfist.gameObject.SetActive(true);
                rightfist.gameObject.SetActive(false);
                TurnHand *= -1;
            }
            DestroySpot();
            SpawnAgain();
        }
        else
        {
            Debug.Log("실패");
            Invoke("DestroySpot", 1.0f);
            Invoke("SpawnAgain", 2.0f);

        }

    }

    public void Stage1_5()
    {
        righthand.gameObject.SetActive(false);
        lefthand.gameObject.SetActive(false);

        count++;
        GameObject.Find("GameManager").GetComponent<GameManager>().PlayCount++;
        if (SpotPos - 125 < handlePos && handlePos < SpotPos + 125)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().score++;
            Debug.Log("성공");
            audioSource.Play();

            
            if (TurnHand == 1)
            {
                rightfist.gameObject.SetActive(true);
                leftfist.gameObject.SetActive(false);
                TurnHand *= -1;
            }
            else
            {
                leftfist.gameObject.SetActive(true);
                rightfist.gameObject.SetActive(false);
                TurnHand *= -1;
            }

            DestroySpot();
            if (count == 1)
            {
                im_1.gameObject.SetActive(true);
                Bob_1.gameObject.SetActive(true);

            }
            else if (count == 2)
            {

                im_2.gameObject.SetActive(true);


            }
            else if (count == 3)
            {
                Bob_1.gameObject.SetActive(false);
                Bob_2.gameObject.SetActive(true);
                im_3.gameObject.SetActive(true);

            }
            else if (count == 4)
            {
                
                im_4.gameObject.SetActive(true);

            }
            else if (count == 5)
            {
                
                Bob_2.gameObject.SetActive(false);
                Bob_3.gameObject.SetActive(true);
                im_5.gameObject.SetActive(true);
            }
            else if (count == 6)
            {
                
                im_6.gameObject.SetActive(true);
                SceneManager.LoadScene("NewMenuScene");
            }




            SpawnAgain();
        }
        else
        {
            Debug.Log("실패");
            Invoke("DestroySpot", 1.0f);
            Invoke("SpawnAgain", 2.0f);

        }
    }
    void SpawnAgain()
    {
        GameObject.Find("SpawnManager").GetComponent<SpawnManager>().SpawnSpot();
        GetSpotPos();
    }

    private void DestroySpot()
    {
        Destroy(GameObject.FindGameObjectWithTag("Spot"));
    }

    void GetSpotPos()
    {
        SpotPos = GameObject.FindGameObjectWithTag("Spot").transform.position.x;
    }

    
    
    // Start is called before the first frame update
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
