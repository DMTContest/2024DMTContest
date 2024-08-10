using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tuxing3 : MonoBehaviour
{
    public Countdown countdown; // ���õ���ʱ�ű�
    public TextMeshProUGUI answerButtonLabel; // ���ⰴť�ϵ�������ʾ

    private string correctAnswer = "��"; // ������ȷ��

    public void OnAnswerButton1Clicked()
    {
        CheckAnswer("��");
    }

    public void OnAnswerButton2Clicked()
    {
        CheckAnswer("����");
    }

    public void OnAnswerButton3Clicked()
    {
        CheckAnswer("è");
    }

    public void OnAnswerButton4Clicked()
    {
        CheckAnswer("����");
    }

    private void CheckAnswer(string chosenAnswer)
    {
        if (chosenAnswer == correctAnswer)
        {
            Debug.Log("����ˣ�");
            SceneManager.LoadScene("Kuaida4");
        }
        else
        {
            Debug.Log("����ˣ�����10�룡");
            countdown.ReduceTime(10f);
        }
    }
}
