using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AG3Instance : MonoBehaviour
{
    private static AG3Instance instance = null;
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
        if(SceneManager.GetActiveScene().name == "AnalysisGame3"){
            _time = GetTimeFromAG3Scene1();
        }
        if(SceneManager.GetActiveScene().name == "AG32")
        {
            _time = GetTimeFromAG3Scene2(); 
        }   

        }

    private float GetTimeFromAG3Scene1()
    {
        // 查第一关脚本并获取其 time 属性的值
        Countdown2c c= FindObjectOfType<Countdown2c>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromAG3Scene2()
    {
        Countdown2c s2 = FindObjectOfType<Countdown2c>();
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
