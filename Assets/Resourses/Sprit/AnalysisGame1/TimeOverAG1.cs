using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeOverAG1: MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ChangeScene());
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3f);
        // 切换到下一个场景
        UnityEngine.SceneManagement.SceneManager.LoadScene("FinalClassAG1");
    }
}
