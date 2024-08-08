using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class AnaRecord : MonoBehaviour
{
    [SerializeField]private Text RecordScore;

    void Start()
    {
        RecordScore.text = "得分：" + TimeManager.RecordScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
