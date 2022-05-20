using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class btn_RandomBtn : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    public Image righthand;
    public Image lefthand;
    public Image rightfist;
    public Image leftfist;

    private int TurnHand = 1;

    public void OnClicked()
    {
        /*
        righthand.gameObject.SetActive(false);
        lefthand.gameObject.SetActive(false);

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
        */
        audioSource.Play();
        GameObject.Find("GameManager").GetComponent<GameManager>().score++;
        GameObject.Find("GameManager").GetComponent<GameManager>().PlayCount++;
        Destroy(this.gameObject);
    }
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        StartCoroutine("delayTime");
        
        
        
    }
    IEnumerator delayTime()
    {
        yield return new WaitForSeconds(4f);
        
        Destroy(this.gameObject, 2.5f);
        GameObject.Find("GameManager").GetComponent<GameManager>().PlayCount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
