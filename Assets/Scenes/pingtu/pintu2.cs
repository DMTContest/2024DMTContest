using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu2 : MonoBehaviour
{
    public Countdown countdown;
    public Button[] choiceButtons; // ѡ��ť����
    public Image silhouetteImage1; // ��һ����ӰͼƬ
    public Image silhouetteImage2; // �ڶ�����ӰͼƬ
    public Image silhouetteImage3; // ��������ӰͼƬ
    public Image silhouetteImage4; // ���ĸ���ӰͼƬ

    private int correctButtonIndex1 = 0; // ��һ����ȷ��ť������
    private int correctButtonIndex2 = 1; // �ڶ�����ȷ��ť������
    private int correctButtonIndex3 = 2; // ��������ȷ��ť������
    private int correctButtonIndex4 = 3; // ���ĸ���ȷ��ť������

    private bool buttonClicked1 = false; // ��¼��һ����ť�Ƿ񱻵��
    private bool buttonClicked2 = false; // ��¼�ڶ�����ť�Ƿ񱻵��
    private bool buttonClicked3 = false; // ��¼��������ť�Ƿ񱻵��
    private bool buttonClicked4 = false; // ��¼���ĸ���ť�Ƿ񱻵��

    void Start()
    {
        // ��ӵ���¼�������
        for (int i = 0; i < choiceButtons.Length; i++)
        {
            int index = i; // ���浱ǰ�����Ա��ڱհ���ʹ��
            choiceButtons[i].onClick.AddListener(() => OnChoiceButtonClicked(index));
        }
    }

    void OnChoiceButtonClicked(int buttonIndex)
    {
        // �жϵ���İ�ť�Ƿ�����ȷ�İ�ť
        if (buttonIndex == correctButtonIndex1)
        {
            silhouetteImage1.color = Color.white; // ������ȷʱ��Ӱ���ɫ
            buttonClicked1 = true;
        }
        else if (buttonIndex == correctButtonIndex2)
        {
            silhouetteImage2.color = Color.white; // ������ȷʱ��Ӱ���ɫ
            buttonClicked2 = true;
        }
        else if (buttonIndex == correctButtonIndex3)
        {
            silhouetteImage3.color = Color.white; // ������ȷʱ��Ӱ���ɫ
            buttonClicked3 = true;
        }
        else if (buttonIndex == correctButtonIndex4)
        {
            silhouetteImage4.color = Color.white; // ������ȷʱ��Ӱ���ɫ
            buttonClicked4 = true;
        }
        else
        {
            countdown.ReduceTime(10f);
        }

        CheckAllButtonsClicked();
    }

    void CheckAllButtonsClicked()
    {
        if (buttonClicked1 && buttonClicked2 && buttonClicked3&&buttonClicked4)
        {
            // ����Ŀ�갴ť��������ˣ�����ҳ����ת
            SceneManager.LoadScene("Pintu"); // �滻�����Ŀ�곡������
        }
    }
}
