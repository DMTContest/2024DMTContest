using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageZoomOut : MonoBehaviour
{
    [SerializeField]private float zoomFactor = 100.0f; // 初始缩放比例
    [SerializeField]private float targetScale = 1.0f; // 目标缩放比例
    [SerializeField]private float duration = 10.0f; // 缩放动画持续时间
    private float elapsedTime = 0.0f; // 当前经过的时间

    private bool isScaledToNormal = false; // 是否已经缩放至正常大小

    private void Start()
    {
        // 设置初始缩放
        transform.localScale = Vector3.one * zoomFactor;
    }

    private void Update()
    {
        if (!isScaledToNormal)
        {
            // 更新经过的时间
            elapsedTime += Time.deltaTime;

            // 计算当前缩放比例
            float currentScale = Mathf.Lerp(zoomFactor, targetScale, elapsedTime / duration);

            // 应用新的缩放
            transform.localScale = Vector3.one * currentScale;

            // 如果动画完成，则重置
            if (elapsedTime >= duration)
            {
                isScaledToNormal = true;
                transform.localScale = Vector3.one * targetScale;
            }
        }
    }
}