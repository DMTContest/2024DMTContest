using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuizManager : MonoBehaviour
{
    public Countdown countdown;
    public bool scene1isright = false;
    //[SerializeField]private string TargetScene;

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
        scene1isright = true;
        SwitchToNextPage();
    }

    void SwitchToNextPage()
    {
        // 在这里实现切换页面的具体逻辑，例如加载新场景或者显示另一个UI界面
        // 例如，可以使用 Unity 的场景管理器加载新场景：
        // 或者显示另一个UI界面：
        // nextUIPanel.SetActive(true);
        Debug.Log("完成第一关，切换到第二关");
        // 将 timeStart 的值传递到下一个场景
        // 获取S1中CountDown类的timeStart值

        // 将startTime传递给S2
       
        // 缓存当前场景的 TextBox1 引用
        // 加载新场景
        SceneManager.LoadScene("AG22");


        // 保存当前场景的倒计时 UI 引用
        //CountdownManager.instance.SetCountdownText(FindObjectOfType<Countdown>().textBox);
    }

    }