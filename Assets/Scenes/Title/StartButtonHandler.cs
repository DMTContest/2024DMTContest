using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHandler : MonoBehaviour
{
    public string nextSceneName = "Twoperson"; // 下一个场景的名称

    public void StartGame()
    {
        // 当按钮被点击时，加载下一个场景
        SceneManager.LoadScene(nextSceneName);
        AudioManager.Instance.PlaySFX("Click");
    }
}