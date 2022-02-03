using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    public int Gold;     //���

    public int nowOnfield = 0;  //���� �ʵ忡 �����ϴ� ���� ��
    public int canOnfield;      //�ʵ忡 ���� �� �ִ� ���� ��

    public float PlayerHP;      
    public float Timer;
    public float Level;         //�÷��̾� ����

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
