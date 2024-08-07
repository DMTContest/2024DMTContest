using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select10 : MonoBehaviour
{
    public Countdown countdown;
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
        // 选择A时切换到下一个页面
        SwitchToNextPage();

    }

    public void OnClickB()
    {
        countdown.ReduceTime(10f); // 选择A时减少10秒倒计时
        Debug.Log("选择了选项 B，当前倒计时：" + countdown.timeStart);
    }

    public void OnClickC()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了选项 C，当前倒计时：" + countdown.timeStart);
    }

    void SwitchToNextPage()
    {
        Debug.Log("切换到下一个页面");
        // 在这里实现切换页面的具体逻辑，例如加载新场景或者显示另一个UI界面
        // 例如，可以使用 Unity 的场景管理器加载新场景：
        //SceneManager.LoadScene("Select10"); ;
        // 或者显示另一个UI界面：
        // nextUIPanel.SetActive(true);
    }
}
