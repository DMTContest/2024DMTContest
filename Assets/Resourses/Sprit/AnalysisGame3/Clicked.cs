using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked : MonoBehaviour
{
    public QuizManager2c quizManager2C;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnMouseDown()
    {
        // 获取当前点击的游戏物件
        GameObject clickedObject = gameObject;

        // 检查游戏物件的 tag 是否为 "1"
        if (clickedObject.tag == "1")
        {
            quizManager2C.isCorrect();
        }
        else if(clickedObject.tag == "0")
        {
            quizManager2C.isWrong();
        }
    }
}
