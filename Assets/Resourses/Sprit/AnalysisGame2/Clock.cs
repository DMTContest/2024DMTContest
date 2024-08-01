using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public QuizManager quizManager;
    public float rotationSpeed = 30f; // 每秒旋转的角度
    public SpriteRenderer Minute;
    public SpriteRenderer Hour;
    public int MinuteNum = 0;
    public int MoveNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
        MoveNum -= 1;
        Minute.transform.RotateAround(Vector3.zero, Vector3.forward, rotationSpeed);
        MinuteNum -= 1;
        if(MinuteNum<0){
            Hour.transform.RotateAround(Vector3.zero, Vector3.forward, rotationSpeed);
            MinuteNum = 11;
        }
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
        MoveNum += 1;
        Minute.transform.RotateAround(Vector3.zero, Vector3.forward, -rotationSpeed);
        MinuteNum += 1;
        if(MinuteNum==12){
            Hour.transform.RotateAround(Vector3.zero, Vector3.forward, -rotationSpeed);
            MinuteNum = 0;
        }
    }
    if (Input.GetKeyDown(KeyCode.Return)){
        if(MoveNum==12){
            Debug.Log("答对啦！");
            quizManager.isCorrect();
        }
        else{
            Debug.Log("答错了......");
            quizManager.isWrong();
        }
    }
}
}
