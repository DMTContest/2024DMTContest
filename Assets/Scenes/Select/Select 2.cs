using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select2 : MonoBehaviour
{
    public SectionCountdownManager countdownManager;
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
        countdownManager.ReduceTime(10f); // ѡ��Aʱ����10�뵹��ʱ
        Debug.Log("ѡ����ѡ�� A����ǰ����ʱ��" + countdownManager.timeStart);
    }

    public void OnClickB()
    {
        countdownManager.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����ѡ�� B����ǰ����ʱ��" + countdownManager.timeStart);
    }

    public void OnClickC()
    {
        // ѡ��Bʱ�л�����һ��ҳ��
        SwitchToNextPage();
        
    }

    void SwitchToNextPage()
    {
        Debug.Log("�л�����һ��ҳ��");
        // ������ʵ���л�ҳ��ľ����߼�����������³���������ʾ��һ��UI����
        // ���磬����ʹ�� Unity �ĳ��������������³�����
        SceneManager.LoadScene("Select3"); ;
        // ������ʾ��һ��UI���棺
        // nextUIPanel.SetActive(true);
    }
}