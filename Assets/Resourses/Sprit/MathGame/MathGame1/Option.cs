using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    
    Vector3 worldPos;
    public void GetMousePosition(){
        // 获取鼠标位置
        Vector3 MousePos = Input.mousePosition;

        // 将鼠标位置从屏幕坐标系转换为世界坐标系
        this.worldPos = Camera.main.ScreenPointToRay(MousePos).origin;
        //Debug.Log("鼠标的坐标系："+worldPos);
    }
    
    
    float minX,minY,maxX,maxY;
    
    public void GetColliderPosition(Collider2D collider){
        //Collider中心点坐标
            Vector3 centerPosition = collider.bounds.center;
            float centerX = centerPosition.x;
            float centerY = centerPosition.y;

        // 获取 Collider 边界坐标
            Vector3 minPosition = collider.bounds.min;
            this.minX = minPosition.x;
            this.minY = minPosition.y;

            Vector3 maxPosition = collider.bounds.max;
            this.maxX = maxPosition.x;
            this.maxY = maxPosition.y;

            //Debug.Log("已获取Collider信息");

    }
    public bool isContainInCollider;
    public bool CheakIfContain(){
        //判断鼠标位置是否在Collider内
        if (worldPos.x >= minX && worldPos.x <= maxX && worldPos.y >= minY && worldPos.y <= maxY)
        {
            isContainInCollider = true;
            //Debug.Log("鼠标位置在Collider内");
            return true;
        }else{
            //Debug.Log("鼠标位置不在Collider内");
            return false;
        }
        
    }

    private bool isChoose = false;
    private Option AOption; // 00选项的脚本引用
    private Option BOption; // 01选项的脚本引用
    private Option COption; // 10选项的脚本引用
    private Option DOption; // 11选项的脚本引用
 [SerializeField] Color choose;
    [SerializeField] Color unchoose;
private void CheakAnswer(){
    //Debug.Log("正在调用答案检查器");
    Option CorrectOption1 = AOption;
    Option CorrectOption2 = DOption;

    Option WrongOption1 = COption;
    Option WrongOption2 = BOption;
    
    
    if(CorrectOption1.isChoose==true && 
    CorrectOption2.isChoose==true &&
    WrongOption1.isChoose==false &&
    WrongOption2.isChoose==false ){
    Debug.Log("答对啦!");}
    
}
private void ChangeColor()
{
    isChoose = !isChoose;
    //Debug.Log("此时"+ gameObject.name + "的isChoose状态为" + GameObject.Find(gameObject.name).GetComponent<Option>().isChoose);
}
public void SetColor(Color choose,Color unchoose,Renderer renderer){
        if(isChoose==true){
            renderer.material.color = choose;
            //Debug.Log("颜色为已选择");
        }
        else if(isChoose==false){renderer.material.color = unchoose;
        //Debug.Log("颜色为未选择");
        }}
        
    
private void Start()
{
    //获得选项的脚本引用
    GameObject OA = GameObject.Find("OA");
    AOption = OA.GetComponent<Option>();

    GameObject OB = GameObject.Find("OB");
    BOption = OB.GetComponent<Option>();

    GameObject OC = GameObject.Find("OC");
    COption = OC.GetComponent<Option>();

    GameObject OD = GameObject.Find("OD");
    DOption = OD.GetComponent<Option>();

    //Debug.Log("已经引用四个选项脚本");

}
    private void OnMouseDown() {
        if (Input.GetMouseButtonDown(0))
        {
        
        // 获取当前游戏对象的Renderer组件
        Renderer renderer = gameObject.GetComponent<Renderer>(); 
        
        // 获取鼠标位置
        GetMousePosition();

         Collider2D collider = gameObject.GetComponent<Collider2D>();
        GetColliderPosition(collider);
        
        // 检查鼠标位置的x和y坐标是否在指定范围内
        if (CheakIfContain())
        {
            // 切换颜色
            ChangeColor();
            SetColor(choose,unchoose,renderer);
            CheakAnswer();
        }  
        }
    }
}
   
