using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select7 : MonoBehaviour
{
    public Countdown countdown;
    public Button buttonA;
    public Button buttonB;
    public Button buttonC;

    void Start()
    {
        buttonA.onClick.AddListener(OnClickA);
        buttonB.onClick.AddListener(OnClickB);
        buttonC.onClick.AddListener(OnClickC);
    }

    public void OnClickA()
    {
        countdown.ReduceTime(10f); // ѡ��Aʱ����10�뵹��ʱ
        Debug.Log("ѡ����ѡ�� A����ǰ����ʱ��" + countdown.timeStart);
    }

    public void OnClickB()
    {
        // ѡ��Bʱ�л�����һ��ҳ��
        SwitchToNextPage();
    }

    public void OnClickC()
    {
        countdown.ReduceTime(10f); // ѡ��Cʱ����10�뵹��ʱ
        Debug.Log("ѡ����ѡ�� B����ǰ����ʱ��" + countdown.timeStart);
    }

    void SwitchToNextPage()
    {
        Debug.Log("�л�����һ��ҳ��");
        // ������ʵ���л�ҳ��ľ����߼�����������³���������ʾ��һ��UI����
        // ���磬����ʹ�� Unity �ĳ��������������³�����
        SceneManager.LoadScene("Select8"); ;
        // ������ʾ��һ��UI���棺
        // nextUIPanel.SetActive(true);
    }
}