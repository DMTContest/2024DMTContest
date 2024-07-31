using UnityEngine;
using UnityEngine.SceneManagement;

public class ClothesButtonHandler : MonoBehaviour
{
    public string nextSceneName = "Twoperson"; // 下一个场景的名称
    public string buttonName; // 当前按钮的名称

    public void OnButtonClick()
    {
        // 保存按钮名称到PlayerPrefs
        PlayerPrefs.SetString("SelectedButton", buttonName);
        PlayerPrefs.Save();

        // 加载下一个场景
        SceneManager.LoadScene(nextSceneName);
    }
}