using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    public int Gold;     //골드

    public int nowOnfield = 0;  //현재 필드에 존재하는 유닛 수
    public int canOnfield;      //필드에 놓을 수 있는 유닛 수

    public float PlayerHP;      
    public float Timer;
    public float Level;         //플레이어 레벨

    public Text GoldTxt;
    public Text TimerTxt;
    public Text FieldTxt;


    private void Start()
    {
        TimerTxt.text = Timer.ToString();
        
    }

    private void Update()
    {
        Timer -= Time.deltaTime;
        TimerTxt.text = ((int)Timer).ToString();
        GoldMinus();
        FieldTxt.text = nowOnfield.ToString() +"/" +canOnfield.ToString();
    }

    public void GoldMinus()
    {
        GoldTxt.text = Gold.ToString();
    }
}
