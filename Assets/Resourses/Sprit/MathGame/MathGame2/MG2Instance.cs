using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG2Instance : MonoBehaviour
{
    private static MG2Instance instance = null;
    public float _time = 0f;
    private void Awake()
    {
        // 确保只有一个 SceneTransition 实例
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        // 从 SceneTime 脚本中获取 time 的值
        if(SceneManager.GetActiveScene().name == "MathGame2"){
            _time = GetTimeFromScene1();
        }
        if(SceneManager.GetActiveScene().name == "MG22")
        {
            _time = GetTimeFromMG2Scene2(); 
        }   

        }

    private float GetTimeFromScene1()
    {
        // 查第一关脚本并获取其 time 属性的值
        SCMG21Time1 c= FindObjectOfType<SCMG21Time1>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromMG2Scene2()
    {
        SCMG22Time s2 = FindObjectOfType<SCMG22Time>();
        if (s2 != null)
        {
            return s2.timeStart;
        }
        else
        {
            return 0f;
        }
    }

  //静态类输出
    public static float Time
    {
        get { return instance != null ? instance._time : 0f; }
    }
}
