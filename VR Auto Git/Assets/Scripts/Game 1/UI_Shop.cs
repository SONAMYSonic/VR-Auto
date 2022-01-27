using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Shop : MonoBehaviour
{
    public ChampionSpawn ChampionSpawn;
    public Manager_Shop managerShop;
    public PlayerStat playerStat;

    public void Shop_Click_Slot0()
    {
        ShopInteract(0);
    }

    public void Shop_Click_Slot1()
    {
        ShopInteract(1);
    }

    public void Shop_Click_Slot2()
    {
        ShopInteract(2);
    }

    public void Shop_Click_Slot3()
    {
        ShopInteract(3);
    }

    public void Shop_Click_Slot4()
    {
        ShopInteract(4);
    }

    public void Refresh_Click()
    {
        managerShop.ShopRandom();

        for(int i = 0; i <= 4; i++)
        {
            managerShop.UI_Shop[i].SetActive(true);
        }
    }

    public void ShopInteract(int a)
    {
        int x = 0;
        for(int i = 0; i < 9; i++)
        {
            if(ChampionSpawn.ChampionArray[i] != null)
            {
                x++;
            }
        }
        
        if (x >= 9)
        {
            Debug.Log("못사임마");
        }
        else
        {
            PlayerStat.Gold -= managerShop.Gold_OnShop[a];
            managerShop.UI_Shop[a].SetActive(false);
            ChampionSpawn.championSpawn(a);
        }

    }

}
