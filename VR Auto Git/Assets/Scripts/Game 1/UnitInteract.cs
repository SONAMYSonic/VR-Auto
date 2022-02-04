using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnitInteract : MonoBehaviour
{
    public bool isTracking = false;
    public GameObject Hand;
    public Transform HandTr;

    private void Start()
    {
        Hand = GameObject.FindWithTag("RightController");
        HandTr = Hand.transform;
    }

    public void unitClicked()
    {
        if(isTracking == false)
        {
            //Ʈ��ŷ ����
            this.transform.SetParent(HandTr.transform);

            isTracking = true;
        }
        else if(isTracking == true)
        {
            //Ʈ��ŷ ����
            this.transform.parent = null;

            isTracking = false;
        }
        
        
    }

}
