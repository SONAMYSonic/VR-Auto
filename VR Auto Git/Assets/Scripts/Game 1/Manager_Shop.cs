using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_Shop : MonoBehaviour
{
    public GameObject[] UI_Shop = new GameObject[5];

    public Sprite[] UnitShopUI;

    // Start is called before the first frame update
    void Start()
    {
        ShopRandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShopRandom()
    {
        int temp = 0;
        for(int i = 0; i < UI_Shop.Length; i++)
        {
            temp = Random.Range(0, UnitShopUI.Length);
            UI_Shop[i].GetComponent<Image>().sprite = UnitShopUI[temp];
        }
    }
}
