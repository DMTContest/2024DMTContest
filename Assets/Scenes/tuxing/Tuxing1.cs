using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tuxing : MonoBehaviour
{
    public Countdown countdown; // ���õ���ʱ�ű�
    public TextMeshProUGUI answerButtonLabel; // ���ⰴť�ϵ�������ʾ

    private string correctAnswer = "��è"; // ������ȷ��

    public void OnAnswerButton1Clicked()
    {
        CheckAnswer("����");
    }

    public void OnAnswerButton2Clicked()
    {
        CheckAnswer("��è");
    }

    public void OnAnswerButton3Clicked()
    {
        CheckAnswer("����");
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
            SceneManager.LoadScene("Kuaida2");
        }
        else
        {
            Debug.Log("����ˣ�����10�룡");
            countdown.ReduceTime(10f);
        }
    }
}
