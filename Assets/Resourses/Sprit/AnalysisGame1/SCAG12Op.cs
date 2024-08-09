using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCAG12Op : MonoBehaviour
{
    [SerializeField] public SCAG12Time sCAG12Time;
    //选项控制：3个
    public SpriteRenderer Option1;
    public SpriteRenderer Option2;
    public SpriteRenderer Option3;
    public SpriteRenderer ChooseO1;
    public SpriteRenderer ChooseO2;
    public SpriteRenderer ChooseO3;

    public int optionNum = 0; //当前选择的是哪一个
    [SerializeField]public AnalysisGame2TIme analysisGame2TIme;


    private void Start()
    {
        UpdateOptionDisplay();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            optionNum++;
            if (optionNum > 2)
                optionNum = 2;
            UpdateOptionDisplay();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            optionNum--;
            if (optionNum < 0)
                optionNum = 0;
            UpdateOptionDisplay();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log($"选择了第{optionNum + 1}个选项");
            if(optionNum==0){
                Debug.Log("选择了第1个答错了");
                if (analysisGame2TIme != null)
                {
                analysisGame2TIme.ReduceTime(10f);
                }
            }
            else if(optionNum==1){
                Debug.Log("选择了第2个答对了");
                //SceneManager.LoadScene("AG12");
            }
            else if(optionNum==2){
                Debug.Log("选择了第3个答错了");
                if (analysisGame2TIme != null)
                {
                analysisGame2TIme.ReduceTime(10f);
                }

            }
        }
    }

    private void UpdateOptionDisplay()
    {
        Option1.sortingOrder = optionNum == 0 ? -3 : 2;
        ChooseO1.sortingOrder = optionNum == 0 ? 2 : -3;
        Option2.sortingOrder = optionNum == 1 ? -3 : 2;
        ChooseO2.sortingOrder = optionNum == 1 ? 2 : -3;
        Option3.sortingOrder = optionNum == 2 ? -3 : 2;
        ChooseO3.sortingOrder = optionNum == 2 ? 2 : -3;
    }
}

