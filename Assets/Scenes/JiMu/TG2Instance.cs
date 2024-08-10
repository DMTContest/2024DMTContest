using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TG2Instance : MonoBehaviour
{
    private static TG2Instance instance = null;
    public float _time = 0f;
    private void Awake()
    {
        // ȷ��ֻ��һ�� SceneTransition ʵ��
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
        // �� SceneTime �ű��л�ȡ time ��ֵ
        if (SceneManager.GetActiveScene().name == "JiMu1")
        {
            _time = GetTimeFromScene1();
        }
        if (SceneManager.GetActiveScene().name == "JiMu2")
        {
            _time = GetTimeFromTG1Scene2();
        }

    }

    private float GetTimeFromScene1()
    {
        // ���һ�ؽű�����ȡ�� time ���Ե�ֵ
        Countdown c = FindObjectOfType<Countdown>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromTG1Scene2()
    {
        JMTG22Time s2 = FindObjectOfType<JMTG22Time>();
        if (s2 != null)
        {
            return s2.timeStart;
        }
        else
        {
            return 0f;
        }
    }

    //��̬�����
    public static float Time
    {
        get { return instance != null ? instance._time : 0f; }
    }
}
