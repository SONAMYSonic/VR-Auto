using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.Extras;

public class Manager : MonoBehaviour
{
    public GameObject LeftController, RightController;
    public GameObject LeftLaser, RightLaser;

    public void HandChange()
    {
        if (RightController.GetComponent<SteamVR_LaserPointer>().enabled == true)
        {
            UnitInteract.LeftOrRight = 0;
            RightLaser = RightController.transform.GetChild(1).gameObject;

            RightController.GetComponent<SteamVR_LaserPointer>().enabled = false;
            RightLaser.SetActive(false);
            LeftController.GetComponent<SteamVR_LaserPointer>().enabled = true;
            LeftLaser.SetActive(true);

            
        }
        else if(LeftController.GetComponent<SteamVR_LaserPointer>().enabled == true)
        {
            UnitInteract.LeftOrRight = 1;
            LeftLaser = LeftController.transform.GetChild(1).gameObject;

            RightController.GetComponent<SteamVR_LaserPointer>().enabled = true;
            RightLaser.SetActive(true);
            LeftController.GetComponent<SteamVR_LaserPointer>().enabled = false;
            LeftLaser.SetActive(false);

            
        }
        
    }

}
