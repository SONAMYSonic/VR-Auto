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
        if(playerStat.Gold >= 2)
        {
            managerShop.ShopRandom();
            playerStat.Gold -= 2;

            for (int i = 0; i <= 4; i++)
            {
                managerShop.UI_Shop[i].SetActive(true);
            }
        }
        


    }

    public void levelUP_Click()
    {
        if(playerStat.Gold >= 4)
        {
            playerStat.canOnfield += 1;
            playerStat.Gold -= 4;
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
        
        if (x >= 9 || managerShop.Gold_OnShop[a] > playerStat.Gold)
        {
            Debug.Log("못사임마");
        }
        else
        {
            playerStat.Gold -= managerShop.Gold_OnShop[a];
            managerShop.UI_Shop[a].SetActive(false);
            ChampionSpawn.championSpawn(a);
        }

    }

}
