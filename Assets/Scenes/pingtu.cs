using UnityEngine;
using UnityEngine.UI;

public class pingtu : MonoBehaviour
{
    public Countdown countdown;
    public Button[] choiceButtons; // ѡ��ť����
    public Image silhouetteImage1; // ��һ��heiͼƬ
    public Image silhouetteImage2; // �ڶ���heiͼƬ
    public Image silhouetteImage3; // �ڶ���heiͼƬ

    private int correctButtonIndex1 = 0; // ��һ����ȷ��ť������
    private int correctButtonIndex2 = 1; // �ڶ�����ȷ��ť������
    private int correctButtonIndex3 = 2; // ��������ȷ��ť������

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
            silhouetteImage1.color = Color.white; // ������ȷʱhei����ɫ
        }
        else if (buttonIndex == correctButtonIndex2)
        {
            // ִ����ȷ��ť2���߼���������¼�ӰͼƬ��ɫ
            silhouetteImage2.color = Color.white; // ������ȷʱhei����ɫ
        }
        else if(buttonIndex==correctButtonIndex3)
        {
            // ִ����ȷ��ť3���߼���������¼�ӰͼƬ��ɫ
            silhouetteImage3.color = Color.white; // ������ȷʱhei����ɫ
        }
        else
        {
            countdown.ReduceTime(10f);
        }
    }
}