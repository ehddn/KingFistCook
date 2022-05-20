using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonManager : MonoBehaviour
{
    enum MenuName
    {
        None,
        FistOfRice,
        SalmonSushi,
        PorkCutlet
    }
    public bool[] bMenuOpened = new bool[5];

    public void OnMouseOver()
    {
        transform.localScale *= 1.3f;
    }
    public void OnMouseExit()
    {
        transform.localScale /= 1.3f;
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void CheckMenuOpened(int num)
    {
        bMenuOpened[num] = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
