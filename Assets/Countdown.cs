using System.Collections;
using UnityEngine;
using TMPro;
using System;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public float timeStart = 60f;

    void Start()
    {
        StartCoroutine(CountdownRoutine());
    }

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