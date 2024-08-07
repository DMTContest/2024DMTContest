using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoInGame1 : MonoBehaviour
{
    public void SwitchToScene()
    {
        SceneManager.LoadScene("AnalysisGame");
    }
}