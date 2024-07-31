using UnityEngine;
using UnityEngine.UI;

public class TwopersonButtonReader : MonoBehaviour
{
    public Text buttonTextDisplay; // 显示按钮名称的文本组件

    private void Start()
    {
        // 从PlayerPrefs读取按钮名称
        string selectedButton = PlayerPrefs.GetString("SelectedButton", "");

        // 显示按钮名称
        if (!string.IsNullOrEmpty(selectedButton))
        {
            buttonTextDisplay.text = "Selected Button: " + selectedButton;
        }
    }
}