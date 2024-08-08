using UnityEngine;
using System.Collections;

public class TimeOver: MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ChangeScene());
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3f);
        // 切换到下一个场景
        UnityEngine.SceneManagement.SceneManager.LoadScene("FinalClass1");
    }
}