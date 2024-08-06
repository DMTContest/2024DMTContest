using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    private static SceneTransition instance = null;
    public float _time = 0f;
    private float Correct;

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
        // 从 Scene1Time 脚本中获取 time 的值
        if(SceneManager.GetActiveScene().name == "AnalysisGame2"){
            _time = GetTimeFromScene1Time();
            if (GetBollFromScene1Bool())
            {
                //Debug.Log("第一关正确");
                Correct = 1;
                Debug.Log("答对题数：" + Correct);
            } }
        else if(SceneManager.GetActiveScene().name == "AG22")
        {
            _time = GetTimeFromScene22Time();
            if (GetBollFromScene22Bool())
            {
                //Debug.Log("第2关正确");
                Correct = 2;
                Debug.Log("答对题数：" + Correct);
            }
        }
        else if (SceneManager.GetActiveScene().name == "AG23")
        {
            _time = GetTimeFromScene23Time();
            if (GetBollFromScene23Bool())
            {
                //Debug.Log("第3关正确");
                Correct = 3;
                Debug.Log("答对题数：" + Correct);
            }
        }
        else if (SceneManager.GetActiveScene().name == "AG24")
        {
            _time = GetTimeFromScene24Time();
            if (GetBollFromScene24Bool())
            {
                //Debug.Log("第4关正确");
                Correct = 4;
                Debug.Log("答对题数：" + Correct);
            }
        }
        else if (SceneManager.GetActiveScene().name == "AG25")
        {
            _time = GetTimeFromScene25Time();
            if (GetBollFromScene25Bool())
            {
                //Debug.Log("第5关正确");
                Correct = 5;
                Debug.Log("答对题数：" + Correct);
            }
        }
        else if (SceneManager.GetActiveScene().name == "AG26")
        {
            _time = GetTimeFromScene26Time();
            if (GetBollFromScene26Bool())
            {
                //Debug.Log("第6关正确");
                Correct = 6;
                Debug.Log("答对题数：" + Correct);
            }
        }
        else if (SceneManager.GetActiveScene().name == "AG27")
        {
            _time = GetTimeFromScene27Time();
            if (GetBollFromScene27Bool())
            {
                //Debug.Log("第7关正确");
                Correct = 7;
                Debug.Log("答对题数：" + Correct);
            }
        }
        else if (SceneManager.GetActiveScene().name == "AG28")
        {
            _time = GetTimeFromScene28Time();
            if (GetBollFromScene28Bool())
            {
                //Debug.Log("第8关正确");
                Correct = 8;
                Debug.Log("答对题数：" + Correct);
            }
        }
        else if (SceneManager.GetActiveScene().name == "AG29")
        {
            _time = GetTimeFromScene29Time();
            if (GetBollFromScene29Bool())
            {
                //Debug.Log("第9关正确");
                Correct = 9;
                Debug.Log("答对题数：" + Correct);
            }
        }
        else if (SceneManager.GetActiveScene().name == "AG210")
        {
            _time = GetTimeFromScene210Time();
            if (GetBollFromScene210Bool())
            {
                //Debug.Log("第2关正确");
                Correct = 10;
                Debug.Log("答对题数：" + Correct);
            }
        }

    }

    private float GetTimeFromScene1Time()
    {
        // 查找 Scene1Time 脚本并获取其 time 属性的值
        Countdown c= FindObjectOfType<Countdown>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private bool GetBollFromScene1Bool()
    {
        // 查找 Scene1Time 脚本并获取其 time 属性的值
        QuizManager q = FindObjectOfType<QuizManager>();
        if (q != null)
        {
            return q.scene1isright;
        }
        else
        {
            return false;
        }
    }

    private float GetTimeFromScene22Time()
    {
        Scene22 s22 = FindObjectOfType<Scene22>();
        if (s22 != null)
        {
            return s22.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    private bool GetBollFromScene22Bool()
    {
        Scene22 s22 = FindObjectOfType<Scene22>();
        if (s22 != null)
        {
            return s22.scene2isright;
        }
        else
        {
            return false;
        }
    }

    private float GetTimeFromScene23Time()
    {
        Scene23 s23 = FindObjectOfType<Scene23>();
        if (s23 != null)
        {
            return s23.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    private bool GetBollFromScene23Bool()
    {
        Scene23 s23 = FindObjectOfType<Scene23>();
        if (s23 != null)
        {
            return s23.scene3isright;
        }
        else
        {
            return false;
        }
    }
    private float GetTimeFromScene24Time()
    {
        Scene24 s24= FindObjectOfType<Scene24>();
        if (s24 != null)
        {
            return s24.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    private bool GetBollFromScene24Bool()
    {
        Scene24 s24 = FindObjectOfType<Scene24>();
        if (s24 != null)
        {
            return s24.scene4isright;
        }
        else
        {
            return false;
        }
    }

    private float GetTimeFromScene25Time()
    {
        Scene25 s25 = FindObjectOfType<Scene25>();
        if (s25 != null)
        {
            return s25.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    private bool GetBollFromScene25Bool()
    {
        Scene25 s25 = FindObjectOfType<Scene25>();
        if (s25 != null)
        {
            return s25.scene5isright;
        }
        else
        {
            return false;
        }
    }

    private float GetTimeFromScene26Time()
    {
        Scene26 s26 = FindObjectOfType<Scene26>();
        if (s26 != null)
        {
            return s26.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    private bool GetBollFromScene26Bool()
    {
        Scene26 s26 = FindObjectOfType<Scene26>();
        if (s26 != null)
        {
            return s26.scene6isright;
        }
        else
        {
            return false;
        }
    }
    private float GetTimeFromScene27Time()
    {
        Scene27 s27 = FindObjectOfType<Scene27>();
        if (s27 != null)
        {
            return s27.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    private bool GetBollFromScene27Bool()
    {
        Scene27 s27 = FindObjectOfType<Scene27>();
        if (s27 != null)
        {
            return s27.scene7isright;
        }
        else
        {
            return false;
        }
    }
    private float GetTimeFromScene28Time()
    {
        Scene28 s28 = FindObjectOfType<Scene28>();
        if (s28 != null)
        {
            return s28.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    private bool GetBollFromScene28Bool()
    {
        Scene28 s28 = FindObjectOfType<Scene28>();
        if (s28 != null)
        {
            return s28.scene8isright;
        }
        else
        {
            return false;
        }
    }
    private float GetTimeFromScene29Time()
    {
        Scene29 s29 = FindObjectOfType<Scene29>();
        if (s29 != null)
        {
            return s29.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    private bool GetBollFromScene29Bool()
    {
        Scene29 s29 = FindObjectOfType<Scene29>();
        if (s29 != null)
        {
            return s29.scene9isright;
        }
        else
        {
            return false;
        }
    }
    private float GetTimeFromScene210Time()
    {
        Scene30 s30 = FindObjectOfType<Scene30>();
        if (s30 != null)
        {
            return s30.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    private bool GetBollFromScene210Bool()
    {
        Scene30 s30= FindObjectOfType<Scene30>();
        if (s30 != null)
        {
            return s30.scene10isright;
        }
        else
        {
            return false;
        }
    }
    public static float Time
    {
        get { return instance != null ? instance._time : 0f; }
    }
     public static bool is1right
    {
        get { return instance != null ? instance.GetBollFromScene1Bool(): false; }
    }
         public static bool is2right
    {
        get { return instance != null ? instance.GetBollFromScene22Bool(): false; }
    }
         public static bool is3right
    {
        get { return instance != null ? instance.GetBollFromScene23Bool(): false; }
    }
         public static bool is4right
    {
        get { return instance != null ? instance.GetBollFromScene24Bool(): false; }
    }
         public static bool is5right
    {
        get { return instance != null ? instance.GetBollFromScene25Bool(): false; }
    }
        public static bool is6right
    {
        get { return instance != null ? instance.GetBollFromScene26Bool(): false; }
    }
        public static bool is7right
    {
        get { return instance != null ? instance.GetBollFromScene27Bool(): false; }
    }
        public static bool is8right
    {
        get { return instance != null ? instance.GetBollFromScene28Bool(): false; }
    }
        public static bool is9right
    {
        get { return instance != null ? instance.GetBollFromScene29Bool(): false; }
    }
        public static bool is10right
    {
        get { return instance != null ? instance.GetBollFromScene210Bool(): false; }
    }
}