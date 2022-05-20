using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timeText;
    private float startTime;
    public int timelimit;

    // Start is called before the first frame update
    void Start()
    {
        //timelimit = GameObject.Find("GameManager").GetComponent<GameManager>().Timelimit;
        startTime = timelimit;
    }
    void TimeCount()
    {
        float t = startTime - Time.time;
        timeText.text = ((int)t).ToString();
    }
    // Update is called once per frame
    void Update()
    {
        TimeCount();  
        if (int.Parse(timeText.text)==0) //타임아웃시
        {
            //gamemanager.주먹이운다()
            Destroy(this);

        }
    }
}
