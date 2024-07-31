using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choosesex : MonoBehaviour
{
   public Button btnBoy;
    public Button btnGirl;
    public Text sexText;
    public Canvas canvas2;

    private void Start()
    {
        // 初始化时设置btnBoy和btnGirl的点击事件处理器
        btnBoy.onClick.AddListener(() => UpdateSexText("性别：男"));
        btnGirl.onClick.AddListener(() => UpdateSexText("性别：女"));
    }

    private void UpdateSexText(string sex)
    {
        // 更新sexText的文本
        sexText.text = sex;
        
        // 隐藏canvas2
        canvas2.gameObject.SetActive(false);
    }
}
