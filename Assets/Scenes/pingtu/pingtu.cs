using UnityEngine;
using UnityEngine.UI;

public class pingtu : MonoBehaviour
{
    public Countdown countdown;
    public Button[] choiceButtons; // 选择按钮数组
    public Image silhouetteImage1; // 第一个hei图片
    public Image silhouetteImage2; // 第二个hei图片
    public Image silhouetteImage3; // 第二个hei图片

    private int correctButtonIndex1 = 0; // 第一个正确按钮的索引
    private int correctButtonIndex2 = 1; // 第二个正确按钮的索引
    private int correctButtonIndex3 = 2; // 第三个正确按钮的索引

    void Start()
    {
        // 添加点击事件监听器
        for (int i = 0; i < choiceButtons.Length; i++)
        {
            int index = i; // 保存当前索引以便在闭包中使用
            choiceButtons[i].onClick.AddListener(() => OnChoiceButtonClicked(index));
        }
    }

    void OnChoiceButtonClicked(int buttonIndex)
    {
        // 判断点击的按钮是否是正确的按钮
        if (buttonIndex == correctButtonIndex1)
        {
            // 执行正确按钮1的逻辑，例如更新剪影图片颜色
            silhouetteImage1.color = Color.white; // 假设正确时hei变绿色
        }
        else if (buttonIndex == correctButtonIndex2)
        {
            // 执行正确按钮2的逻辑，例如更新剪影图片颜色
            silhouetteImage2.color = Color.white; // 假设正确时hei变绿色
        }
        else if(buttonIndex==correctButtonIndex3)
        {
            // 执行正确按钮3的逻辑，例如更新剪影图片颜色
            silhouetteImage3.color = Color.white; // 假设正确时hei变绿色
        }
        else
        {
            countdown.ReduceTime(10f);
        }
    }
}