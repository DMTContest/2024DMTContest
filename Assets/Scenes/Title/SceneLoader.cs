using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
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
    
private void Start()
{
    //获得选项的脚本引用
    //GameObject BTN = GameObject.Find("Btn_new");
    //Option OptionBTN = BTN.GetComponent<Option>();

}
    private void OnMouseDown() {
        if (Input.GetMouseButtonDown(0))
        {
        
        // 获取当前游戏对象的Renderer组件
        //Renderer renderer = gameObject.GetComponent<Renderer>(); 
        
        // 获取鼠标位置
        GetMousePosition();

         Collider2D collider = gameObject.GetComponent<Collider2D>();
        GetColliderPosition(collider);
        
        // 检查鼠标位置的x和y坐标是否在指定范围内
        if (CheakIfContain())
        {
            LoadScene();
        }  
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Twoperson");
    }
}