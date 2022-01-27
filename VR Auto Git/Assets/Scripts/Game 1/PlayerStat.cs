using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    public static int Gold;

    public float PlayerHP;
    public float Timer;

    public Text GoldTxt;
    public Text TimerTxt;

    private void Start()
    {
        TimerTxt.text = Timer.ToString();
    }

    private void Update()
    {
        Timer -= Time.deltaTime;
        TimerTxt.text = ((int)Timer).ToString();
        GoldMinus();
    }

    public void GoldMinus()
    {
        GoldTxt.text = Gold.ToString();
    }
}
