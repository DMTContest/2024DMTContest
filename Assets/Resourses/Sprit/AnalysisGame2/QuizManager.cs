using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public Countdown countdown;


    void Start()
    {
        
    }

    public void isWrong()
    {
        countdown.ReduceTime(10f); // 选择A时减少10秒倒计时
        Debug.Log("答错啦，当前倒计时：" + countdown.timeStart);
    }


    public void isCorrect()
    {
        // 选择C时切换到下一个页面
        SwitchToNextPage();
    }

    void SwitchToNextPage()
    {
        Debug.Log("切换到下一个页面");
        // 在这里实现切换页面的具体逻辑，例如加载新场景或者显示另一个UI界面
        // 例如，可以使用 Unity 的场景管理器加载新场景：
        // SceneManager.LoadScene("NextScene");
        // 或者显示另一个UI界面：
        // nextUIPanel.SetActive(true);
    }

}