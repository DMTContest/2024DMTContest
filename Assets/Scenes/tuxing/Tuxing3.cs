using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tuxing3 : MonoBehaviour
{
    public Countdown countdown; // 引用倒计时脚本
    public TextMeshProUGUI answerButtonLabel; // 答题按钮上的文字显示

    private string correctAnswer = "鱼"; // 设置正确答案

    public void OnAnswerButton1Clicked()
    {
        CheckAnswer("鱼");
    }

    public void OnAnswerButton2Clicked()
    {
        CheckAnswer("海豚");
    }

    public void OnAnswerButton3Clicked()
    {
        CheckAnswer("猫");
    }

    public void OnAnswerButton4Clicked()
    {
        CheckAnswer("仓鼠");
    }

    private void CheckAnswer(string chosenAnswer)
    {
        if (chosenAnswer == correctAnswer)
        {
            Debug.Log("答对了！");
            SceneManager.LoadScene("Kuaida4");
        }
        else
        {
            Debug.Log("答错了！减少10秒！");
            countdown.ReduceTime(10f);
        }
    }
}
