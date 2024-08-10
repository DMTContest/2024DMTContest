using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fangkuai : MonoBehaviour
{
    public Button[] buttons; // ��ť���������������������

    void Start()
    {
        // ��ÿ����ť��ӵ���¼�������
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // ���浱ǰ�����Ա��ڱհ���ʹ��
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
        }
    }

    void OnButtonClicked(int buttonIndex)
    {
        // ����ť����¼�
        Debug.Log("Button clicked: " + buttonIndex);

        // ��������ػ����ٰ�ť
        buttons[buttonIndex].gameObject.SetActive(false); // ���ذ�ť

        // ʵ�������߼����������ʾ����ʵ����Ŀ����Ҫ������Ϸ�߼��޸ģ�
        MoveDownObjects();
    }

    void MoveDownObjects()
    {
        // ��ʵ����Ŀ�У�ʵ������������߼�
        // ������Բο� Match-3 ��Ϸ�е����������㷨������������±���ÿ�У�����λ����Ϸ��������
        // �������ʾ��������ÿ���������Ϸ�������ֱ������һ��

        for (int i = 0; i < buttons.Length; i++)
        {
            if (!buttons[i].gameObject.activeSelf)
            {
                // ��������һ�񣬼���ʾ���Ϸ����������ƶ�һ����λ
                Vector3 currentPosition = buttons[i].transform.position;
                buttons[i].transform.position = new Vector3(currentPosition.x, currentPosition.y - 1f, currentPosition.z);

                // ��ʵ����Ŀ�п�����Ҫ����ƶ�������ƽ���ƶ�Ч��
            }
        }
    }
}
