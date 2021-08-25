using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmanager : MonoBehaviour
{
    
    public GameObject mainpanel;
    public GameObject ndpanel;
    public static mainmanager instance;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void plus()
    {
        SceneManager.LoadScene("Plus");
    }
    public void minus()
    {
        SceneManager.LoadScene("minus");
    }

public void multiply()
{
    SceneManager.LoadScene("multiply");
}

 public void divide()
{
    SceneManager.LoadScene("Divide");
}
    public void all()
    {
        SceneManager.LoadScene("All");
    }
    public void exit()
    {
        Application.Quit();
    }
}
