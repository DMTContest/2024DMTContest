using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PTJG12Time : MonoBehaviour
{
    float local_score;//��ǰ�ؿ���ʵʱ�÷�

    //����ģʽ��Ҫ������
    public float timeStart;//�ӵ���ģʽ�л�ȡ����һ�ؿ��м̳еĵ���ʱ
    public float scene2iswrong = 0;//��һ��������ٴ�
    [SerializeField] public TextMeshProUGUI textBox;//�󶨵���ʱ���ı�

    // Start is called before the first frame update
    void Start()
    {
        //�ӵ���ģʽ�л�ȡʱ��
        timeStart = JG1Instance.Time;
        //����ʱϵͳ
        StartCoroutine(CountdownRoutine());

    }

    // Update is called once per frame
    void Update()
    {

    }

    //����ʱϵͳ
    IEnumerator CountdownRoutine()
    {
        while (timeStart > 0f)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
            UpdateUI(); // ����UI
            yield return new WaitForSeconds(1f);
            timeStart -= 1f;
        }
        textBox.text = "0";
        UpdateUI(); // ȷ������ʱ��Ϊ0ʱҲ����UI
        Debug.Log("����ʱ������");
        //SceneManager.LoadScene("TimeOverAG1");
    }

    void UpdateUI()
    {
        // ȷ�������߳��ϸ���UI
        if (textBox != null)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
        }
    }
    // ���ٵ���ʱ�ķ���
    public void ReduceTime(float amount)
    {
        timeStart -= amount;
        if (timeStart < 0f)
        {
            timeStart = 0f;
        }
        UpdateUI(); // ÿ�μ���ʱ��ʱ����UI
    }
}
