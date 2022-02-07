using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnitInteract : MonoBehaviour
{
    public bool isTracking = false;
    public GameObject LeftHand, RightHand;
    public Transform LeftHandTr, RightHandTr;

    public static int LeftOrRight = 1;  //������ 0 �������� 1

    private void Start()
    {
        LeftHand = GameObject.FindWithTag("LeftController");
        RightHand = GameObject.FindWithTag("RightController");

        LeftHandTr = LeftHand.transform;
        RightHandTr = RightHand.transform;
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
                    break;
                case 1:
                    this.transform.SetParent(RightHandTr.transform);
                    isTracking = true;
                    break;
            }
        }
        else if(isTracking == true)
        {
            //Ʈ��ŷ ����
            this.transform.parent = null;

            isTracking = false;
        }

    }

}
