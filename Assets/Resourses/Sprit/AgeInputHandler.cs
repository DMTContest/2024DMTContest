using UnityEngine;
using UnityEngine.UI;

public class AgeInputHandler : MonoBehaviour
{
    public InputField inputAge;
    public Text ageText;
    public Button btnBack;
    public Canvas canvas1;

    private void Start()
    {
        // 设置inputAge的值变化事件处理器
        inputAge.onValueChanged.AddListener(UpdateAgeText);

        // 设置btnBack的点击事件处理器
        btnBack.onClick.AddListener(HideCanvas1);
    }

    private void UpdateAgeText(string age)
    {
        // 更新ageText的文本
        ageText.text = "年龄：" + age;
    }

    private void HideCanvas1()
    {
        // 隐藏canvas1
        canvas1.gameObject.SetActive(false);
    }
}