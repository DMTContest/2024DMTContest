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

    private float timeLeft = 60f; // ��ʼ����ʱʱ��
    private bool isAnswered = false; // �Ƿ��Ѿ��ش������

    void Start()
    {
        // ���������ѡ���ı����ⲿ����Ҫ���ݾ������������
        questionText.text = "Which is correct?";
        buttonTextA.text = "Option A";
        buttonTextB.text = "Option B";
        buttonTextC.text = "Option C";

        // ����ť��ӵ���¼�����
        buttonA.onClick.AddListener(() => CheckAnswer("A"));
        buttonB.onClick.AddListener(() => CheckAnswer("B"));
        buttonC.onClick.AddListener(() => CheckAnswer("C"));
    }

    void CheckAnswer(string selectedAnswer)
    {
        if (!isAnswered)
        {
            isAnswered = true; // ��ֹ��ε��

            string correctAnswer = "C"; // ������ȷ���� B��ʵ�����������Ҫ�޸�

            // �ж�ѡ���Ƿ���ȷ
            if (selectedAnswer == correctAnswer)
            {
                // �ش���ȷ����ť����ɫ
                ChangeButtonColor(selectedAnswer, Color.green);
            }
            else
            {
                // �ش���󣬰�ť���ɫ������ʱ��ȥʮ��
                ChangeButtonColor(selectedAnswer, Color.red);
                timeLeft -= 10f;
            }

            // ���µ���ʱ��ʾ
            UpdateTimeLeft();

            // �ڴ˿��Լ���������һ���߼���������ʾ��һ�������
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
        // ���µ���ʱ��ʾ
        Debug.Log("Time Left: " + timeLeft); // ��ʵ����Ŀ�п����Ǹ���UI��ʾ
    }
}
