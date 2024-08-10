using UnityEngine;
using UnityEngine.UI;

public class jianying2 : MonoBehaviour
{
    public Countdown countdown;
    public Button[] choiceButtons; // ѡ��ť����
    public Image silhouetteImage1; // ��һ����ӰͼƬ

    private int correctButtonIndex1 = 1; // ��һ����ȷ��ť������

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
            // ִ����ȷ��ť1���߼���������¼�ӰͼƬ��ɫ
            silhouetteImage1.color = Color.green; // ������ȷʱ��Ӱ����ɫ
        }
        else
        {
            countdown.ReduceTime(10f);
        }
    }
}