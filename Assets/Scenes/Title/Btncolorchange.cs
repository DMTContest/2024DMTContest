using UnityEngine;
using UnityEngine.UI;

public class Btncolorchange : MonoBehaviour
{
    public Color wantedColor;
    public Button button;
    private bool isWantedColor; // 用于跟踪当前是否是想要的颜色
    private Color originalColor; // 保存按钮的原始颜色

    // Start is called before the first frame update
    void Start()
    {
        // 获取并保存按钮的原始颜色
        originalColor = button.colors.normalColor;
        isWantedColor = false;
    }

    public void ChangeButtonColor()
    {
        if (isWantedColor)
        {
            // 如果当前是想要的颜色，则恢复到原始颜色
            SetButtonColor(originalColor);
        }
        else
        {
            // 否则，设置颜色为wantedColor
            SetButtonColor(wantedColor);
        }
        // 切换颜色状态
        isWantedColor = !isWantedColor;
    }

    private void SetButtonColor(Color color)
    {
        // 更新按钮颜色
        ColorBlock cb = button.colors;
        cb.normalColor = color;
        cb.highlightedColor = color;
        cb.pressedColor = color;
        button.colors = cb;
    }
}