using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class SwapOrderInLayer : MonoBehaviour
{
    public SpriteRenderer Option1;
    public SpriteRenderer Option2;
    public SpriteRenderer ChooseO1;
    public SpriteRenderer ChooseO2;
    //public SpriteRenderer[] spriteRenderers;
    public int optionNum = 0;
    private void Start() {
        //spriteRenderers[0] = Option1;
        //spriteRenderers[1] = Option2;

    }

    private void Update()     
{
    if(Input.GetMouseButtonDown(0)){
        Debug.Log("mousedown");}
        //SwapOrders();}
    // 检测方向键是否被按下
if (Input.GetKey(KeyCode.RightArrow))
{
Debug.Log("Right arrow key is being held down.");
optionNum += 1;
if(optionNum>1){optionNum=1;
if(optionNum==0){
        Option1.sortingOrder = -3;
        ChooseO1.sortingOrder=1;
        Option2.sortingOrder = 1;
        ChooseO2.sortingOrder=-3;
    }

        if(optionNum==1){
        Option2.sortingOrder = -3;
        ChooseO2.sortingOrder=1;
        Option1.sortingOrder = 1;
        ChooseO1.sortingOrder=-3;
    }}
        
    }

    if (Input.GetKey(KeyCode.LeftArrow))
    {
        Debug.Log("Left arrow key is being held down.");
        optionNum -= 1;
        if(optionNum<0){
            optionNum=0;
            if(optionNum==0){
        Option1.sortingOrder = -3;
        ChooseO1.sortingOrder=1;
        Option2.sortingOrder = 1;
        ChooseO2.sortingOrder=-3;
    }

            if(optionNum==1){
        Option2.sortingOrder = -3;
        ChooseO2.sortingOrder=1;
        Option1.sortingOrder = 1;
        ChooseO1.sortingOrder=-3;
    }
        }

        
    }
    if (Input.GetKeyDown(KeyCode.Return))
    {
        Debug.Log("Enter key was pressed!");
        // 在这里可以添加你的代码逻辑
        if(optionNum==0){
        Debug.Log("选择了第一个，答对了！");
    }
        if(optionNum==1){
        Debug.Log("选择了第二个，打错了！");
    }
    }
        
}

    /*private void SwapOrders()
    {
        // 保存原来的Order in Layer
        int originalSquare1Order = Option1.sortingOrder;
        int originalSquare2Order = Option2.sortingOrder;

        // 交换Order in Layer
        Option1.sortingOrder = originalSquare2Order;
        Option2.sortingOrder = originalSquare1Order;
    }*/
}