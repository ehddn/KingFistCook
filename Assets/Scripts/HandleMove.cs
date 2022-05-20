using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleMove : MonoBehaviour
{
    public float speed;
    public float rightMax;
    public float leftMax;
    public float currentpos;
    public float YPos;
    //public float direction = 3.0f; 

    /*public void MoveHandle()
    {
        float pos = transform.position.x;
        

    }*/

    // Start is called before the first frame update
    void Start()
    {
        currentpos = transform.position.x;
        YPos = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        currentpos += Time.deltaTime * speed;
        if (currentpos >= rightMax)
        {
            speed *= -1;
            currentpos = rightMax;
        }
        else if (currentpos <= leftMax)
        {
            speed *= -1;
            currentpos = leftMax;

        }

        transform.position = new Vector2(currentpos, YPos);
        
    }
}
