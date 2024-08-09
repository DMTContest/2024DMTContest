using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select10 : MonoBehaviour
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
        // ѡ��Aʱ�л�����һ��ҳ��
        SwitchToNextPage();

    }

    public void OnClickB()
    {
       countdownManager .ReduceTime(10f); // ѡ��Aʱ����10�뵹��ʱ
        Debug.Log("ѡ����ѡ�� B����ǰ����ʱ��" + countdownManager .timeStart);
    }

    public void OnClickC()
    {
        countdownManager.ReduceTime(10f); // ѡ��Bʱ����10�뵹��ʱ
        Debug.Log("ѡ����ѡ�� C����ǰ����ʱ��" + countdownManager.timeStart);
    }

    void SwitchToNextPage()
    {
        Debug.Log("�л�����һ��ҳ��");
        // ������ʵ���л�ҳ��ľ����߼�����������³���������ʾ��һ��UI����
        // ���磬����ʹ�� Unity �ĳ��������������³�����
        //SceneManager.LoadScene("Select10"); ;
        // ������ʾ��һ��UI���棺
        // nextUIPanel.SetActive(true);
    }
}
