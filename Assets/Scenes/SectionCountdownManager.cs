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
            DontDestroyOnLoad(gameObject); // 保证在场景切换时不销毁
        }
        else
        {
            Destroy(gameObject); // 如果已经有其他实例存在，则销毁当前实例
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
        Debug.Log("倒计时结束！");
        isCounting = false;
    }
    public void UpdateUI()
    {
        // 确保在主线程上更新UI
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