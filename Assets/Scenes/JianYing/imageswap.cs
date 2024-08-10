using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageSwap : MonoBehaviour
{
    public Countdown countdown;
    public Button[] choiceButtons; // ѡ��ť����
    public Image silhouetteImage1; // ��һ����ӰͼƬ
    public Image silhouetteImage2; // �ڶ�����ӰͼƬ

    private int correctButtonIndex1 = 0; // ��һ����ȷ��ť������
    private int correctButtonIndex2 = 2; // �ڶ�����ȷ��ť������

    private bool buttonClicked1 = false; // ��¼��һ����ť�Ƿ񱻵��
    private bool buttonClicked2 = false; // ��¼�ڶ�����ť�Ƿ񱻵��

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
            silhouetteImage1.color = Color.green; // ������ȷʱ��Ӱ����ɫ
            buttonClicked1 = true;
        }
        else if (buttonIndex == correctButtonIndex2)
        {
            silhouetteImage2.color = Color.green; // ������ȷʱ��Ӱ����ɫ
            buttonClicked2 = true;
        }
        else
        {
            countdown.ReduceTime(10f);
        }

        CheckAllButtonsClicked();
    }

    void CheckAllButtonsClicked()
    {
        if (buttonClicked1 && buttonClicked2)
        {
            // ����Ŀ�갴ť��������ˣ�����ҳ����ת
            SceneManager.LoadScene("JianYing2"); // �滻�����Ŀ�곡������
        }
    }
}