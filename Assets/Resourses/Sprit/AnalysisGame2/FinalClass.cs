using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using System.Data;

public class FinalClass : MonoBehaviour
{   
    [SerializeField]private TextMeshProUGUI JR;
    [SerializeField]private TextMeshProUGUI JW;
    [SerializeField]private TextMeshProUGUI MR;
    [SerializeField]private TextMeshProUGUI MW;
    [SerializeField]private TextMeshProUGUI HR;
    [SerializeField]private TextMeshProUGUI HW;
    [SerializeField]private TextMeshProUGUI GameDateNow;
    [SerializeField]private TextMeshProUGUI FinalScore;


    // Start is called before the first frame update
    void Start()
    {
        JR.text = TimeManager.Jcorrect.ToString();
        MR.text = TimeManager.Mcorrect.ToString();
        HR.text = TimeManager.Hcorrect.ToString();  
        JW.text = (TimeManager.JWR1+TimeManager.JWR2+TimeManager.JWR3).ToString();
        MW.text = (TimeManager.MWR1+TimeManager.MWR2+TimeManager.MWR3).ToString();
        HW.text = (TimeManager.HWR1+TimeManager.HWR2+TimeManager.HWR3+TimeManager.HWR4).ToString();  
        GameDateNow.text = DateTime.Now.ToString();
        FinalScore.text = 
        (TimeManager.Jcorrect*10 - (TimeManager.JWR1+TimeManager.JWR2+TimeManager.JWR3)*2+ TimeManager.Mcorrect*10 - (TimeManager.MWR1+TimeManager.MWR2+TimeManager.MWR3)*4+ TimeManager.Hcorrect*10 - (TimeManager.HWR1+TimeManager.HWR2+TimeManager.HWR3+TimeManager.HWR4)*6).ToString();
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
