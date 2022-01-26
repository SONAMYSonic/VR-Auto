using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Shop : MonoBehaviour
{
    public Manager_Shop managerShop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shop_Click_Slot0()
    {
        managerShop.UI_Shop[0].SetActive(false);
    }

    public void Shop_Click_Slot1()
    {
        managerShop.UI_Shop[1].SetActive(false);
    }

    public void Shop_Click_Slot2()
    {
        managerShop.UI_Shop[2].SetActive(false);
    }

    public void Shop_Click_Slot3()
    {
        managerShop.UI_Shop[3].SetActive(false);
    }

    public void Shop_Click_Slot4()
    {
        managerShop.UI_Shop[4].SetActive(false);
    }

}
