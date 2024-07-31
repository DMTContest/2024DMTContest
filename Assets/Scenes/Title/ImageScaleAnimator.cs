using UnityEngine;
using UnityEngine.UI;

public class ImageScaleAnimator : MonoBehaviour
{
    public Image img; // 图片组件引用
    public float scaleSpeed = 0.05f; // 放大缩小的速度
    public float minScale = 0.8f; // 最小缩放比例
    public float maxScale = 1.2f; // 最大缩放比例
    private float targetScale = 1.0f; // 目标缩放比例
    private bool isScalingUp = true; // 当前是否正在放大

    private void Start()
    {
        // 确保img组件已经被正确设置
        if (img == null)
        {
            Debug.LogError("Image component not assigned.");
            enabled = false;
            return;
        }
        
        // 初始化目标缩放比例
        targetScale = isScalingUp ? maxScale : minScale;
    }

    private void Update()
    {
        ScaleImage();
    }

    private void ScaleImage()
    {
        // 使用平滑插值函数使缩放更加平滑
        float currentScale = Mathf.Lerp(img.rectTransform.localScale.x, targetScale, scaleSpeed * Time.deltaTime);
        
        // 应用新的缩放值
        img.rectTransform.localScale = new Vector3(currentScale, currentScale, 1f);

        // 检查是否达到目标缩放值
        if (Mathf.Abs(img.rectTransform.localScale.x - targetScale) < 0.01f)
        {
            // 切换缩放方向并更新目标缩放比例
            isScalingUp = !isScalingUp;
            targetScale = isScalingUp ? maxScale : minScale;
        }
    }
}