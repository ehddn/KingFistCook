using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    //public static GameManager instance = null;

    public int PlayCount=0;
    public int MaxPlayCount;
    public int score;
    public int BigSuccessScore;
    public int SuccessScore;
    public int FailScore;
    public int Timelimit;

    private int SuccessCount;
    public string nextStage;

    public Image BS_Img;
    public Image NS_Img;
    public Image Fail_Img;



    /*private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

    }*/



    // Start is called before the first frame update
    void Start()
    {
        
    }
    void LoadScene()
    {
        SceneManager.LoadScene(nextStage);
    }
    IEnumerator delayLoadScene()
    {
        yield return new WaitForSeconds(5f);
        LoadScene();
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2f);
        
    }
    // Update is called once per frame
    void Update()
    {
        StartCoroutine("delay");
        if (PlayCount == MaxPlayCount)
        {
            if (score == BigSuccessScore)
            {
                StartCoroutine("delay");
                //대성공
                Bigsuccess();
            }
            else if (score == SuccessScore)
            {
                //성공
                StartCoroutine("delay");
                Nsuccess();
            }
            else
            {
                //주먹이 운다
                StartCoroutine("delay");
                Fail();
            }
            StartCoroutine(delayLoadScene());
        }
    }
    void Bigsuccess()
    {
        BS_Img.gameObject.SetActive(true);
    }

    void Nsuccess()
    {
        NS_Img.gameObject.SetActive(true);
    }
    void Fail()
    {
        Fail_Img.gameObject.SetActive(true);
    }
}


