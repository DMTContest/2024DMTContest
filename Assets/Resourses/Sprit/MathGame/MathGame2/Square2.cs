using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Square2 : MonoBehaviour
{
    private bool ischoose = false;
    private Square2 CorrectAnswer;
    //错误答案
    private Square2 WrongAnswer1;
    private Square2 WrongAnswer2;
    private Square2 WrongAnswer3;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Square = GameObject.Find("Square");
        CorrectAnswer= Square.GetComponent<Square2>();

        GameObject Square1 = GameObject.Find("Square1");
        WrongAnswer1= Square1.GetComponent<Square2>();

        GameObject Square2 = GameObject.Find("Square2");
        WrongAnswer2= Square2.GetComponent<Square2>();

        GameObject Square3 = GameObject.Find("Square3");
        WrongAnswer3= Square3.GetComponent<Square2>();
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown() {
        ischoose = !ischoose;
        
            /*Debug.Log("C:"+CorrectAnswer.ischoose);
            Debug.Log("W1:"+WrongAnswer1.ischoose);
            Debug.Log("W2:"+WrongAnswer2.ischoose);
            Debug.Log("W3:"+WrongAnswer3.ischoose);*/
        
        if(CorrectAnswer.ischoose && !WrongAnswer1.ischoose &&
        !WrongAnswer2.ischoose && !WrongAnswer3.ischoose){
            Destroy(gameObject);
            Debug.Log("答对啦");
            //SceneManager.LoadScene("MG22");
        }
        else{
            //Destroy(gameObject);
            Debug.Log("没答对");}
            //SceneManager.LoadScene("MG22");

        }
    }
    

