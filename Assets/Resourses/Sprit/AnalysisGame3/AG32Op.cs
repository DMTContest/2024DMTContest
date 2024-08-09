using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG32Op : MonoBehaviour
{
    // Start is called before the first frame update
    public AG32TIme aG32TIme;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        // 获取当前点击的游戏物件
        GameObject clickedObject = gameObject;
        Debug.Log(clickedObject);

        // 检查游戏物件的 tag 是否为 "1"
        if (clickedObject.tag == "1")
        {
            aG32TIme.isCorrect();
        }
        else if(clickedObject.tag == "0")
        {
            aG32TIme.isWrong();
        }
    }
}
