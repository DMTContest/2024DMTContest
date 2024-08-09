using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCAG12Sink1 : MonoBehaviour
    
{

    //天平下沉所需要的数据
    [SerializeField] private Collider2D SinkPlateCollider1; // 下沉的托盘1

    [SerializeField] private Collider2D squareCollider1; // 较重的物体1

    [SerializeField] private float moveSpeed;//移速
    [SerializeField] private float duration;//周期
    [SerializeField] private float rotationSpeed = 45f; // 每秒旋转的角度
    [SerializeField] private GameObject sinkplate1;//下沉的托盘1

    [SerializeField] private GameObject dontsinkplate1;//没有下沉的托盘

    [SerializeField] private GameObject arm1;//力臂1

    private bool issinkplate1 = false;

    private float  startTime;//该场景单独运行开始的时间
    private float elapsed;//
    // Start is called before the first frame update
    void Start()
    {
        //托盘下沉
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(issinkplate1==true){
             
             elapsed = Time.time - startTime;
             //Debug.Log(elapsed);
             if (elapsed < duration)
            {
                // 更新位置
                sinkplate1.transform.Translate(Vector3.up * (moveSpeed * Time.deltaTime));
                dontsinkplate1.transform.Translate(Vector3.up * (-moveSpeed * Time.deltaTime));
                arm1.transform.Rotate(Vector3.forward * (rotationSpeed+25f) * Time.deltaTime);
            }
            else
            {
                // 如果超过了移动时间，停止移动
                enabled = false; // 停止此脚本的更新
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="SP1"){

            Debug.Log("撞到"+ collision.gameObject.tag);
            issinkplate1 = true;
            
        }
        else if(collision.gameObject.tag=="Sink1"){
            Debug.Log("撞到"+ collision.gameObject.tag);

        }
        
    }
}
