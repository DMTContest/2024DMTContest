using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TlWind : MonoBehaviour
{
    public TextMeshProUGUI questionText;
    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public TextMeshProUGUI buttonTextA;
    public TextMeshProUGUI buttonTextB;
    public TextMeshProUGUI buttonTextC;

    private float timeLeft = 60f; // 初始倒计时时间
    private bool isAnswered = false; // 是否已经回答过问题

    void Start()
    {
        // 设置问题和选项文本，这部分需要根据具体情况来设置
        questionText.text = "Which is correct?";
        buttonTextA.text = "Option A";
        buttonTextB.text = "Option B";
        buttonTextC.text = "Option C";

        // 给按钮添加点击事件监听
        buttonA.onClick.AddListener(() => CheckAnswer("A"));
        buttonB.onClick.AddListener(() => CheckAnswer("B"));
        buttonC.onClick.AddListener(() => CheckAnswer("C"));
    }

    void CheckAnswer(string selectedAnswer)
    {
        if (!isAnswered)
        {
            isAnswered = true; // 防止多次点击

            string correctAnswer = "C"; // 假设正确答案是 B，实际情况根据需要修改

            // 判断选择是否正确
            if (selectedAnswer == correctAnswer)
            {
                // 回答正确，按钮变绿色
                ChangeButtonColor(selectedAnswer, Color.green);
            }
            else
            {
                // 回答错误，按钮变红色，倒计时减去十秒
                ChangeButtonColor(selectedAnswer, Color.red);
                timeLeft -= 10f;
            }

            // 更新倒计时显示
            UpdateTimeLeft();

            // 在此可以继续处理下一步逻辑，例如显示下一个问题等
        }
    }

    void ChangeButtonColor(string buttonName, Color color)
    {
        switch (buttonName)
        {
            case "A":
                buttonA.image.color = color;
                break;
            case "B":
                buttonB.image.color = color;
                break;
            case "C":
                buttonC.image.color = color;
                break;
            default:
                break;
        }
    }

    void UpdateTimeLeft()
    {
        // 更新倒计时显示
        Debug.Log("Time Left: " + timeLeft); // 在实际项目中可能是更新UI显示
    }
}
