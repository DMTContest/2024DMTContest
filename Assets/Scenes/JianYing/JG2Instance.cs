using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class JG2Instance : MonoBehaviour
{
    private static JG2Instance instance = null;
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
        if (SceneManager.GetActiveScene().name == "JianYing")
        {
            _time = GetTimeFromScene1();
        }
        if (SceneManager.GetActiveScene().name == "JianYing2")
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
        JYJG22Time s2 = FindObjectOfType<JYJG22Time>();
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
