using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene26 : MonoBehaviour
{

    [SerializeField]private TextMeshProUGUI textBox;

    public float timeStart;

    private float rotationSpeed = 30f; // 每秒旋转的角度
    [SerializeField] private SpriteRenderer Minute;
    [SerializeField] private SpriteRenderer Hour;
    private int MinuteNum = 0;
    private int MoveNum = 0;
    public float scene6iswrong = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        float timeFromScene1 = TimeManager.Time;
        // 在这里使用 timeFromScene1 的值
        Debug.Log(timeFromScene1);
        timeStart = TimeManager.Time;
        StartCoroutine(CountdownRoutine());
    }

    IEnumerator CountdownRoutine()
    {
        while (timeStart > 0f)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
            UpdateUI(); // 更新UI
            yield return new WaitForSeconds(1f);
            timeStart -= 1f;
        }
        textBox.text = "0";
        UpdateUI(); // 确保最终时间为0时也更新UI
        Debug.Log("倒计时结束！");
        SceneManager.LoadScene("TimeOver");

    }

    void UpdateUI()
    {
        // 确保在主线程上更新UI
        if (textBox != null)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
        }
    }

    // 减少倒计时的方法
    public void ReduceTime(float amount)
    {
        timeStart -= amount;
        if (timeStart < 0f)
        {
            timeStart = 0f;
        }
        UpdateUI(); // 每次减少时间时更新UI
    }

    public void isWrong()
    {
        ReduceTime(10f); // 选择A时减少10秒倒计时
        scene6iswrong+=1;
        //Debug.Log("答错啦，当前倒计时：" + timeStart);
    }


    public void isCorrect()
    {
        // 选择C时切换到下一个页面
        SwitchToNextPage();
    }

    void SwitchToNextPage()
    {

        Debug.Log("切换到下一个页面");
        SceneManager.LoadScene("AG27");

      
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveNum -= 1;
            Minute.transform.RotateAround(Vector3.zero, Vector3.forward, rotationSpeed);
            Hour.transform.RotateAround(Vector3.zero, Vector3.forward, rotationSpeed/12);
            MinuteNum -= 1;
            if (MinuteNum < 0)
            {
                Hour.transform.RotateAround(Vector3.zero, Vector3.forward, rotationSpeed/12);
                MinuteNum = 11;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveNum += 1;
            Minute.transform.RotateAround(Vector3.zero, Vector3.forward, -rotationSpeed);
            Hour.transform.RotateAround(Vector3.zero, Vector3.forward, -rotationSpeed/12);
            MinuteNum += 1;
            if (MinuteNum == 12)
            {
                Hour.transform.RotateAround(Vector3.zero, Vector3.forward, -rotationSpeed/12);
                MinuteNum = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (MoveNum == -8)
            {
                Debug.Log("答对啦！");
                isCorrect();
            }
            else
            {
                Debug.Log("答错了......");
                isWrong();
            }
        }
    }
}

