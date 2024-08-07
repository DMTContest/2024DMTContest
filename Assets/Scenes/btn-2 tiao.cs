using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn2 : MonoBehaviour
{
    public void OnBtnNewClick()
    {
        SceneManager.LoadScene("NameWind");
    }
}

