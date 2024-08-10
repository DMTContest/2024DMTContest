using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCTG12Time : MonoBehaviour
{
    float local_score;//当前关卡中实时得分

    //单例模式需要的数据
    public float timeStart;//从单例模式中获取从上一关卡中继承的倒计时
    public float scene2iswrong = 0;//这一关做错多少次
    public TextMeshProUGUI textBox;//绑定倒计时的文本

    // Start is called before the first frame update
    void Start()
    {
        //从单例模式中获取时间
        timeStart = TG1Instance.Time;
        //倒计时系统
        StartCoroutine(CountdownRoutine());
        
    }

    // Update is called once per frame
    void Update()
    {

    }

//倒计时系统
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
        //SceneManager.LoadScene("TimeOverAG1");
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
    
    
}
