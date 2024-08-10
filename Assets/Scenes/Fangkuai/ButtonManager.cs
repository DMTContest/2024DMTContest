using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Button[] buttons; // 按钮数组
    private bool[] buttonStates; // 按钮状态数组

    void Start()
    {
        buttonStates = new bool[buttons.Length];

        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Capture the current index for the lambda
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
        }
    }

    void OnButtonClicked(int index)
    {
        buttonStates[index] = true;
        CheckAllButtonsClicked();
    }

    void CheckAllButtonsClicked()
    {
        foreach (bool state in buttonStates)
        {
            if (!state) return;
        }

        // 所有按钮都被点击了，进行页面跳转
        SceneManager.LoadScene("FangKuai2"); // 替换成你的目标场景名称
    }
}
