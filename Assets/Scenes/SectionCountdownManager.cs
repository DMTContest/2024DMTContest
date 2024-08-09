using System.Collections;
using UnityEngine;
using TMPro;

public class SectionCountdownManager : MonoBehaviour
{

    public static SectionCountdownManager Instance;

    public TextMeshProUGUI textBox;
    public float timeStart = 60f;
    private bool isCounting = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // ��֤�ڳ����л�ʱ������
        }
        else
        {
            Destroy(gameObject); // ����Ѿ�������ʵ�����ڣ������ٵ�ǰʵ��
        }
    }

    private void Start()
    {
        StartCountdown();
    }

    public void StartCountdown()
    {
        if (!isCounting)
        {
            isCounting = true;
            StartCoroutine(CountdownRoutine());
        }
    }

    IEnumerator CountdownRoutine()
    {
        while (timeStart > 0f)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
            yield return new WaitForSeconds(1f);
            timeStart -= 1f;
        }
        textBox.text = "0";
        Debug.Log("����ʱ������");
        isCounting = false;
    }
    public void UpdateUI()
    {
        // ȷ�������߳��ϸ���UI
        if (textBox != null)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
        }
    }

    public void ReduceTime(float amount)
    {
        timeStart -= amount;
        if (timeStart < 0f)
        {
            timeStart = 0f;
        }
        textBox.text = Mathf.Round(timeStart).ToString();
    }
}