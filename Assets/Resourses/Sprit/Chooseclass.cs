using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chooseclass : MonoBehaviour
{
   public Button btn1;
    public Button btn2;
     public Button btn3;
    public Button btn4;
     public Button btn5;
    public Button btn6;
    public Text classText;
    public Canvas classcanvas;

    private void Start()
    {
        // 初始化时设置btnBoy和btnGirl的点击事件处理器
        btn1.onClick.AddListener(() => UpdateSexText("一年级"));
        btn2.onClick.AddListener(() => UpdateSexText("二年级"));
        btn3.onClick.AddListener(() => UpdateSexText("三年级"));
        btn4.onClick.AddListener(() => UpdateSexText("四年级"));
        btn5.onClick.AddListener(() => UpdateSexText("五年级"));
        btn6.onClick.AddListener(() => UpdateSexText("六年级"));
    }

    private void UpdateSexText(string sex)
    {
        // 更新sexText的文本
        classText.text = sex;
        
        // 隐藏canvas2
        classcanvas.gameObject.SetActive(false);
    }
}

