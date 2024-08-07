using UnityEngine;
using UnityEngine.UI;

public class QuizManager2c : MonoBehaviour
{
    public Countdown2c countdown2c;

    

    private void Start()
    {

    }

    public void isWrong()
    {
        countdown2c.ReduceTime(10f); // 选择A时减少10秒倒计时
        Debug.Log("答错啦，当前倒计时：" + countdown2c.timeStart);
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
        // 例如, SceneManager.LoadScene("NextScene");
    }

    
}