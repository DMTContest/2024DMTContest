using UnityEngine;
using UnityEngine.UI;

public class CanvasToggleScript : MonoBehaviour
{
    public Canvas canvasToToggle; // 这里我们将引用Canvas2

    private void Start()
    {
        // 确保Canvas2在开始时是隐藏的
        canvasToToggle.gameObject.SetActive(false);
    }

    public void OnButtonClicked()
    {
        // 当按钮被点击时，切换Canvas2的可见性
        canvasToToggle.gameObject.SetActive(true);
    }
}