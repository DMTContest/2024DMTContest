using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AG1Instance : MonoBehaviour
{
    private static AG1Instance instance = null;
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
        if(SceneManager.GetActiveScene().name == "AnalysisGame"){
            _time = GetTimeFromScene1();
        }
        if(SceneManager.GetActiveScene().name == "AG12")
        {
            _time = GetTimeFromAG1Scene2(); 
        }   

        }

    private float GetTimeFromScene1()
    {
        // 查第一关脚本并获取其 time 属性的值
        AnalysisGame2TIme c= FindObjectOfType<AnalysisGame2TIme>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromAG1Scene2()
    {
        SCAG12Time s2 = FindObjectOfType<SCAG12Time>();
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
