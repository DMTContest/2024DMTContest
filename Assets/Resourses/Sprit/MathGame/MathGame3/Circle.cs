using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic; // 添加这一行来引入 List<> 类型

public class Circle : MonoBehaviour
{
    [SerializeField] private int number; // 编号
    [SerializeField] private Vector3 startPosition = new Vector3(1f, -10f, 0);
    [SerializeField] private float initialRate = 0.5f;
    [SerializeField] private float decayRate = 0.1f;
    [SerializeField] private float timeInterval = 0.2f;
    [SerializeField] private float maxScale = 3.0f;
    [SerializeField] private Vector3 initialScale = new Vector3(1.0f, 1.0f, 1.0f);
    [SerializeField] private float thresholdScale = 2.0f;
    [SerializeField] private float moveAmplitudeX = 1.0f;
    [SerializeField] private float moveAmplitudeY = 1.0f;
    [SerializeField] private float moveFrequency = 1.0f;
    [SerializeField] private float rotationSpeed = 30.0f;

    private float currentScaleValue = 0f;
    private float timeElapsed = 0f;
    private bool isEliminated = false;

    private void Start()
    {
        transform.position = startPosition;
        transform.localScale = initialScale;
        currentScaleValue = initialScale.x;
        InvokeRepeating("IncreaseScale", 0f, timeInterval);
    }

    private void IncreaseScale()
    {
        if (isEliminated) return;

        float scaleIncrement;
        if (currentScaleValue < thresholdScale)
        {
            scaleIncrement = initialRate;
        }
        else
        {
            scaleIncrement = initialRate * Mathf.Exp(-decayRate * (currentScaleValue - thresholdScale));
        }

        currentScaleValue += scaleIncrement;
        if (currentScaleValue >= maxScale)
        {
            CancelInvoke("IncreaseScale");
            currentScaleValue = maxScale;
        }

        transform.localScale = new Vector3(currentScaleValue, currentScaleValue, 1f);

        timeElapsed += Time.deltaTime;

        float newX = timeElapsed * moveAmplitudeX * moveFrequency + moveAmplitudeX * Mathf.Cos(timeElapsed * moveFrequency);
        float newY = timeElapsed * moveAmplitudeY * moveFrequency + moveAmplitudeY * Mathf.Sin(timeElapsed * moveFrequency);

        transform.position = new Vector3(newX, newY, transform.position.z);

        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
     private void OnMouseDown()
    {
        if (isEliminated) return;

        // 获取 GameManager 实例
        GameManager gameManager = FindObjectOfType<GameManager>();

        if (gameManager != null)
        {
            // 当点击时，调用 GameManager 中的方法
            gameManager.OnCircleClicked(number);
        }
    
        // 销毁此 GameObject
        isEliminated = true;
        Destroy(gameObject);
    }
}