using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnitInteract : MonoBehaviour
{
    public bool isTracking = false;
    public GameObject LeftHand, RightHand;
    public Transform LeftHandTr, RightHandTr;

    Manager manager;

    public static int LeftOrRight = 1;  //왼쪽이 0 오른쪽이 1
    public static int onFieldGraphic = 0;

    private void Start()
    {
        LeftHand = GameObject.FindWithTag("LeftController");
        RightHand = GameObject.FindWithTag("RightController");

        LeftHandTr = LeftHand.transform;
        RightHandTr = RightHand.transform;

        manager = GameObject.FindWithTag("GM").GetComponent<Manager>();
    }

    public void unitClicked()
    {
        if(isTracking == false)
        {
            switch (LeftOrRight)
            {
                case 0:
                    this.transform.SetParent(LeftHandTr.transform);
                    isTracking = true;
                    manager.mapGraphic.SetActive(true);
                    break;
                case 1:
                    this.transform.SetParent(RightHandTr.transform);
                    isTracking = true;
                    manager.mapGraphic.SetActive(true);
                    break;
            }
        }
        else if(isTracking == true)
        {
            //트래킹 종료
            this.transform.parent = null;
            manager.mapGraphic.SetActive(false);
            isTracking = false;
        }

    }



}
