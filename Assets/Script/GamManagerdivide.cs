using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GamManagerdivide : MonoBehaviour
{

    [SerializeField]
    private Text  NumText1,NumText2,ResultText;
    [SerializeField]
    private int num1, num2;
    [SerializeField]
    private int result;
    [SerializeField]
    private Text resultBox1, resultBox2, resultBox3;
    public int cscore;
    public int wscore;
    public Text cuurectscorebox;
    public Text wrongscorebox;
    public GameObject deside;
    public GameObject deside1;
    public EventTrigger[] user;
    public GameObject failed;
    public Text timertext;
    private float secondsCount ;
    
    // Start is called before the first frame update
    void Start()
    {
       
        cscore = 0;
        wscore = 0;
        NumberGenarator();
        StartCoroutine(resultGenarator1());
        StartCoroutine(resultGenarator2());
        StartCoroutine(resultGenarator3());

    }
    void Update()
    {
     

            updatUpdateTimerUI();
        
        cuurectscorebox.text = "Currect Ans: " + cscore;
        wrongscorebox.text = "Wrong Ans: " + wscore;

    }
    public void updatUpdateTimerUI()
    {
        
        secondsCount += Time.deltaTime;
        timertext.text = (int)secondsCount + "s";
        secondsCount += Time.deltaTime;
       
            if (secondsCount >= 15)
            {
                failed.SetActive(true);
                Time.timeScale = 0;
                user[0].enabled = false;
                user[1].enabled = false;
                user[2].enabled = false;
            }
        
    }
    // Update is called once per frame
 


    public void NumberGenarator()
    {

        secondsCount = 0;
        Time.timeScale = 1;

        num1 = Random.Range(1, 10);
        num2 = Random.Range(1, 10);
        NumText1.text = "" + num1;
        NumText2.text = "" + num2;

        result = num1 / num2;
        user[0].enabled = true;
        user[1].enabled = true;
        user[2].enabled = true;
        StartCoroutine(resultGenarator1());
        StartCoroutine(resultGenarator2());
        StartCoroutine(resultGenarator3());
        deside.SetActive(false);
        deside1.SetActive(false);

    }

    IEnumerator resultGenarator1()
    {
        int randomResult = Random.Range((result - 2), (result + 2));
     
        resultBox1.text = "" + randomResult;
        resultBox1.name = "" + randomResult;

        yield return new WaitForSeconds(1f);

        resultBox1.text = "" + randomResult;
        resultBox1.name = "" + randomResult;

        StartCoroutine(resultGenarator1());

      

    }

    IEnumerator resultGenarator2()
    {
        int randomResult = Random.Range((result - 2), (result + 2));
    
        resultBox2.text = "" + randomResult;
        resultBox2.name = "" + randomResult;

        yield return new WaitForSeconds(1f);

        resultBox2.text = "" + randomResult;
        resultBox2.name = "" + randomResult;

        StartCoroutine(resultGenarator2());

       
    }



    IEnumerator resultGenarator3()
    {
        int randomResult = Random.Range((result - 2), (result + 2));
   

        resultBox3.text = "" + randomResult;
        resultBox3.name = "" + randomResult;

        yield return new WaitForSeconds(1f);

        resultBox3.text = "" + randomResult;
        resultBox3.name = "" + randomResult;

        StartCoroutine(resultGenarator3());
   
    }


    public void userResult(Text T)
    {
        Time.timeScale = 0;
        //Debug.Log(EventSystem.current.firstSelectedGameObject.name);
        // Debug.Log("ADFAS");
        print(T.name);

       

        string name = T.name;

        int uResult = int.Parse(name);

        if (uResult == result )
        {
          
            user[0].enabled = false;
            user[1].enabled = false;
            user[2].enabled = false;
            
            deside.SetActive(true);
            //deside1.SetActive(false);
            cscore++;
         
            StopAllCoroutines();
          



            // NumberGenarator();
        }
        else
        {
            
            user[0].enabled = false;
            user[1].enabled = false;
            user[2].enabled = false;

            deside1.SetActive(true);
            //deside.SetActive(false);
            wscore++;
        
            StopAllCoroutines();
          
        }

    }
    public void failedgame()
    {
        SceneManager.LoadScene("Main");
    }

    public void pause()
    {
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Time.timeScale = 1;
    }
    public void previosbutton()
    {


        SceneManager.LoadScene("Main");



    }
    }

 