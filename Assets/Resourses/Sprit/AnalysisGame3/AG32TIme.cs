using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AG32TIme : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public float timeStart = 60f;

    void Start()
    {
        timeStart = AG3Instance.Time;
        StartCoroutine(CountdownRoutine());
    }

    IEnumerator CountdownRoutine()
    {
        while (timeStart > 0f)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
            UpdateUI(); // 更新UI
            yield return new WaitForSeconds(1f);
            timeStart -= 1f;
        }
        textBox.text = "0";
        UpdateUI(); // 确保最终时间为0时也更新UI
        Debug.Log("倒计时结束！");
    }

    void UpdateUI()
    {
        // 确保在主线程上更新UI
        if (textBox != null)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
        }
    }

    // 减少倒计时的方法
    public void ReduceTime(float amount)
    {
        timeStart -= amount;
        if (timeStart < 0f)
        {
            timeStart = 0f;
        }
        UpdateUI(); // 每次减少时间时更新UI
    }
     public void isWrong()
    {
        ReduceTime(10f); // 选择A时减少10秒倒计时
        Debug.Log("答错啦，当前倒计时：" + timeStart);
    }

    public void isCorrect()
    {
        // 选择C时切换到下一个页面
        SwitchToNextPage();
    }

    void SwitchToNextPage()
    {
        Debug.Log("切换到下一个页面");
        // 在这里实现切换页面的具体逻辑
        //SceneManager.LoadScene("AG32");
    }
}
