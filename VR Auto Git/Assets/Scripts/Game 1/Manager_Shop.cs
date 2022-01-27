using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_Shop : MonoBehaviour
{
    public ChampionSpawn championSpawn;

    public GameObject[] UI_Shop = new GameObject[5];
    public int[] Gold_OnShop = new int[5];
    

    public Sprite[] UnitShopUI;
    public int[] UnitGold;

    // Start is called before the first frame update
    void Start()
    {
        ShopRandom();
    }

    public void ShopRandom()
    {
        int temp = 0;
        for(int i = 0; i < UI_Shop.Length; i++)
        {
            temp = Random.Range(0, UnitShopUI.Length);
            championSpawn.shopUnit[i] = temp;
            UI_Shop[i].GetComponent<Image>().sprite = UnitShopUI[temp];
            Gold_OnShop[i] = UnitGold[temp];
        }
    }
}
