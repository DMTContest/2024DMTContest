using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToHome : MonoBehaviour
{
 public string sceneToLoad; // 目标场景的名称

    public void LoadNextScene()
    {
        // 加载指定的场景
        SceneManager.LoadScene(sceneToLoad);
    }
}
