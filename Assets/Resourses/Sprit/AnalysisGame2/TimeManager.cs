using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    private static TimeManager instance = null;
    public float _time = 0f;
    public float JCorrect;
    public float MCorrect;
    public float HCorrect;
    public float JWrong1;
    public float JWrong2;
    public float JWrong3;
    public float MWrong1;
    public float MWrong2;
    public float MWrong3;
    public float HWrong1;
    public float HWrong2;
    public float HWrong3;
    public float HWrong4;
    public string ScoreForAnalyzeWind;

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
            JCorrect=1;
            JWrong1 =GetNumFromScene1Wrong();
        }
        if(SceneManager.GetActiveScene().name == "AG22")
        {
            _time = GetTimeFromScene22Time();
            JCorrect=2;
            JWrong2 =GetNumFromScene22Wrong();

           
        }
        if (SceneManager.GetActiveScene().name == "AG23")
        {
            _time = GetTimeFromScene23Time();
            JCorrect=3;
            JWrong3 =GetNumFromScene23Wrong();

           
        }
        if (SceneManager.GetActiveScene().name == "AG24")
        {
            _time = GetTimeFromScene24Time();
            MCorrect=1;
            MWrong1 =GetNumFromScene24Wrong();
           
        }
        if (SceneManager.GetActiveScene().name == "AG25")
        {
            _time = GetTimeFromScene25Time();
            MCorrect=2;
            MWrong2 =GetNumFromScene25Wrong();
        }
        if (SceneManager.GetActiveScene().name == "AG26")
        {
            _time = GetTimeFromScene26Time();
            MCorrect=3;
            MWrong3 =GetNumFromScene26Wrong();
        }
        if (SceneManager.GetActiveScene().name == "AG27")
        {
            _time = GetTimeFromScene27Time();
            HCorrect=1;
            HWrong1 =GetNumFromScene27Wrong();

        }
        if (SceneManager.GetActiveScene().name == "AG28")
        {
            _time = GetTimeFromScene28Time();
            HCorrect=2;
           HWrong2 =GetNumFromScene28Wrong();
        }
        if (SceneManager.GetActiveScene().name == "AG29")
        {
            _time = GetTimeFromScene29Time();
            HCorrect=3;
            HWrong3 =GetNumFromScene28Wrong();
        }
        if (SceneManager.GetActiveScene().name == "AG210")
        {
            _time = GetTimeFromScene210Time();
            HCorrect=4;
           HWrong4 =GetNumFromScene210Wrong();
        }
        if (SceneManager.GetActiveScene().name == "FinalClass1")
        {
           ScoreForAnalyzeWind = (TimeManager.Jcorrect*30 - (TimeManager.JWR1+TimeManager.JWR2+TimeManager.JWR3)*5+ TimeManager.Mcorrect*50 - (TimeManager.MWR1+TimeManager.MWR2+TimeManager.MWR3)*10+ TimeManager.Hcorrect*80 - (TimeManager.HWR1+TimeManager.HWR2+TimeManager.HWR3+TimeManager.HWR4)*20).ToString();

        }
    }

    private float GetTimeFromScene1Time()
    {
        // 查找 Scene1Time 脚本并获取其 time 属性的值
        AnalysisCountdown c= FindObjectOfType<AnalysisCountdown>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
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

        private float GetNumFromScene1Wrong()
    {
        // 查找 Scene1Time 脚本并获取其 time 属性的值
        AnalysisQuizManager c= FindObjectOfType<AnalysisQuizManager>();
        if (c != null)
        {
            return c.scene1iswrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetNumFromScene22Wrong()
    {
        Scene22 s22 = FindObjectOfType<Scene22>();
        if (s22 != null)
        {
            return s22.scene2iswrong;
        }
        else
        {
            return 0f;
        }
    }

    private float GetNumFromScene23Wrong()
    {
        Scene23 s23 = FindObjectOfType<Scene23>();
        if (s23 != null)
        {
            return s23.scene3iswrong;
        }
        else
        {
            return 0f;
        }
    } 
    private float GetNumFromScene24Wrong()
    {
        Scene24 s24= FindObjectOfType<Scene24>();
        if (s24 != null)
        {
            return s24.scene4iswrong;
        }
        else
        {
            return 0f;
        }
    }   

    private float GetNumFromScene25Wrong()
    {
        Scene25 s25 = FindObjectOfType<Scene25>();
        if (s25 != null)
        {
            return s25.scene5iswrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetNumFromScene26Wrong()
    {
        Scene26 s26 = FindObjectOfType<Scene26>();
        if (s26 != null)
        {
            return s26.scene6iswrong;
        }
        else
        {
            return 0f;
        }
    }

    private float GetNumFromScene27Wrong()
    {
        Scene27 s27 = FindObjectOfType<Scene27>();
        if (s27 != null)
        {
            return s27.scene7iswrong ;
        }
        else
        {
            return 0f;
        }
    }
 
    private float GetNumFromScene28Wrong()
    {
        Scene28 s28 = FindObjectOfType<Scene28>();
        if (s28 != null)
        {
            return s28.scene8iswrong;
        }
        else
        {
            return 0f;
        }
    }

    private float GetNumFromScene29Wrong()
    {
        Scene29 s29 = FindObjectOfType<Scene29>();
        if (s29 != null)
        {
            return s29.scene9iswrong ;
        }
        else
        {
            return 0f;
        }
    }

    private float GetNumFromScene210Wrong()
    {
        Scene30 s30 = FindObjectOfType<Scene30>();
        if (s30 != null)
        {
            return s30.scene10iswrong ;
        }
        else
        {
            return 0f;
        }
    }

    public static float Time
    {
        get { return instance != null ? instance._time : 0f; }
    }

        public static float Jcorrect
    {
        get { return instance != null ? instance.JCorrect : 0f; }
    }
            public static float Mcorrect
    {
        get { return instance != null ? instance.MCorrect : 0f; }
    }
            public static float Hcorrect
    {
        get { return instance != null ? instance.HCorrect : 0f; }
    }
            public static float JWR1
    {
        get { return instance != null ? instance.JWrong1 : 0f; }
    }
            public static float JWR2
    {
        get { return instance != null ? instance.JWrong2 : 0f; }
    }
            public static float JWR3
    {
        get { return instance != null ? instance.JWrong3 : 0f; }
    }
            public static float MWR1
    {
        get { return instance != null ? instance.MWrong1 : 0f; }
    }
            public static float MWR2
    {
        get { return instance != null ? instance.MWrong2 : 0f; }
    }
            public static float MWR3
    {
        get { return instance != null ? instance.MWrong3 : 0f; }
    }
            public static float HWR1
    {
        get { return instance != null ? instance.HWrong1 : 0f; }
    }
            public static float HWR2
    {
        get { return instance != null ? instance.HWrong2 : 0f; }
    }
            public static float HWR3
    {
        get { return instance != null ? instance.HWrong3 : 0f; }
    }
            public static float HWR4
    {
        get { return instance != null ? instance.HWrong4 : 0f; }
    }
            public static string RecordScore
    {
        get { return instance != null ? instance.ScoreForAnalyzeWind : null; }
    }
}