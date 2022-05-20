using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScoreText : MonoBehaviour
{
    public Text MaxScore;
    // Start is called before the first frame update
    void Start()
    {
        int t = GameObject.Find("GameManager").GetComponent<GameManager>().BigSuccessScore;
        MaxScore.text = t.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
