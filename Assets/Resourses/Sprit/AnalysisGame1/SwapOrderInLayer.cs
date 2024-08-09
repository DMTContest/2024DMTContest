using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwapOrderInLayer : MonoBehaviour
{
    public SpriteRenderer Option1;
    public SpriteRenderer Option2;
    public SpriteRenderer ChooseO1;
    public SpriteRenderer ChooseO2;

    [SerializeField]public AnalysisGame2TIme analysisGame2TIme;

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
        ChooseO1.sortingOrder=2;
        Option2.sortingOrder = 2;
        ChooseO2.sortingOrder=-3;
    }

        if(optionNum==1){
        Option2.sortingOrder = -3;
        ChooseO2.sortingOrder=2;
        Option1.sortingOrder = 2;
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
        ChooseO1.sortingOrder=2;
        Option2.sortingOrder = 2;
        ChooseO2.sortingOrder=-3;
    }

            if(optionNum==1){
        Option2.sortingOrder = -3;
        ChooseO2.sortingOrder=2;
        Option1.sortingOrder = 2;
        ChooseO1.sortingOrder=-3;
    }
        }

        
    }
    if (Input.GetKeyDown(KeyCode.Return))
{
    Debug.Log("Enter key was pressed!");
    if (optionNum == 0)
    {
        Debug.Log("选择了第一个，答对了！");
        SceneManager.LoadScene("AG12");
    }
    if (optionNum == 1)
    {
        Debug.Log("选择了第二个，答错了！");
        if (analysisGame2TIme != null)
        {
            analysisGame2TIme.ReduceTime(10f);
        }
        else
        {
            Debug.LogError("analysisGame2TIme is null!");
        }
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