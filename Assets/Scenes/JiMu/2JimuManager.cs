using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JimuManager2 : MonoBehaviour
{
    public Countdown countdown;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;
    public Button button12;

    void Start()
    {
        button1.onClick.AddListener(OnClick1);
        button2.onClick.AddListener(OnClick2);
        button3.onClick.AddListener(OnClick3);
        button4.onClick.AddListener(OnClick4);
        button5.onClick.AddListener(OnClick5);
        button6.onClick.AddListener(OnClick6);
        button7.onClick.AddListener(OnClick7);
        button8.onClick.AddListener(OnClick8);
        button9.onClick.AddListener(OnClick9);
        button10.onClick.AddListener(OnClick10);
        button11.onClick.AddListener(OnClick11);
        button12.onClick.AddListener(OnClick12);
    }

    public void OnClick1()
    {
        countdown.ReduceTime(10f); // ѡ��Aʱ����10�뵹��ʱ
        Debug.Log("ѡ����1����ǰ����ʱ��" + countdown.timeStart);
    }

    public void OnClick2()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����2����ǰ����ʱ��" + countdown.timeStart);
    }

    public void OnClick3()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����3����ǰ����ʱ��" + countdown.timeStart);
    }
    public void OnClick4()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����4����ǰ����ʱ��" + countdown.timeStart);
    }
    public void OnClick5()
    {
        // ѡ��5ʱ�л�����һ��ҳ��
        SwitchToNextPage();
    }
    public void OnClick6()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����6����ǰ����ʱ��" + countdown.timeStart);
    }
    public void OnClick7()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����7����ǰ����ʱ��" + countdown.timeStart);
    }
    public void OnClick8()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����8����ǰ����ʱ��" + countdown.timeStart);
    }
    public void OnClick9()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����9����ǰ����ʱ��" + countdown.timeStart);
    }
    public void OnClick10()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����10����ǰ����ʱ��" + countdown.timeStart);
    }
    public void OnClick11()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����11����ǰ����ʱ��" + countdown.timeStart);
    }
    public void OnClick12()
    {
        countdown.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����12����ǰ����ʱ��" + countdown.timeStart);
    }
    void SwitchToNextPage()
    {
        Debug.Log("�л�����һ��ҳ��");
        // ������ʵ���л�ҳ��ľ����߼�����������³���������ʾ��һ��UI����
        // ���磬����ʹ�� Unity �ĳ��������������³�����
        SceneManager.LoadScene("JimuManager4");
        // ������ʾ��һ��UI���棺
        // nextUIPanel.SetActive(true);
    }
}
