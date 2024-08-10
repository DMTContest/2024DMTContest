using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tuxing2 : MonoBehaviour
{
    public Countdown countdown; // 引用倒计时脚本
    public TextMeshProUGUI answerButtonLabel; // 答题按钮上的文字显示

    private string correctAnswer = "猫"; // 设置正确答案

    public void OnAnswerButton1Clicked()
    {
        CheckAnswer("松鼠");
    }

    public void OnAnswerButton2Clicked()
    {
        CheckAnswer("熊猫");
    }

    public void OnAnswerButton3Clicked()
    {
        CheckAnswer("猫");
    }

    public void OnAnswerButton4Clicked()
    {
        CheckAnswer("大象");
    }

    private void CheckAnswer(string chosenAnswer)
    {
        if (chosenAnswer == correctAnswer)
        {
            Debug.Log("答对了！");
            SceneManager.LoadScene("Kuaida3");
        }
        else
        {
            Debug.Log("答错了！减少10秒！");
            countdown.ReduceTime(10f);
        }
    }
}
