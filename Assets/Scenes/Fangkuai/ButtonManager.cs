using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Button[] buttons; // ��ť����
    private bool[] buttonStates; // ��ť״̬����

    void Start()
    {
        buttonStates = new bool[buttons.Length];

        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Capture the current index for the lambda
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
        }
    }

    void OnButtonClicked(int index)
    {
        buttonStates[index] = true;
        CheckAllButtonsClicked();
    }

    void CheckAllButtonsClicked()
    {
        foreach (bool state in buttonStates)
        {
            if (!state) return;
        }

        // ���а�ť��������ˣ�����ҳ����ת
        SceneManager.LoadScene("FangKuai2"); // �滻�����Ŀ�곡������
    }
}
