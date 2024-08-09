using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCAG12Sink2 : MonoBehaviour
{
    [SerializeField] private Collider2D SinkPlateCollider2; // 下沉的托盘2
    [SerializeField] private Collider2D squareCollider2; // 较重的物体2
    [SerializeField] private float moveSpeed;//移速
    [SerializeField] private float duration;//周期
    [SerializeField] private float rotationSpeed = 40f; // 每秒旋转的角度
    [SerializeField] private GameObject sinkplate2;//下沉的托盘2
    [SerializeField] private GameObject dontsinkplate2;//没有下沉的托盘
    [SerializeField] private GameObject arm2;//力臂2
    private float  startTime;//该场景单独运行开始的时间
    private bool issinkplate2 = false;
    private float elapsed;//

    void Start()
    {
        //托盘下沉
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(issinkplate2==true){
             
             elapsed = Time.time - startTime;
             if (elapsed < duration)
            {
                // 更新位置
                sinkplate2.transform.Translate(Vector3.up * (moveSpeed * Time.deltaTime));
                dontsinkplate2.transform.Translate(Vector3.up * (-moveSpeed * Time.deltaTime));
                arm2.transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
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
        if(collision.gameObject.tag=="SP2"){

            Debug.Log("撞到"+ collision.gameObject.tag);
            issinkplate2 = true;
            
        }
        else if(collision.gameObject.tag=="Sink2"){
            Debug.Log("撞到"+ collision.gameObject.tag);

        }   
    }
}
