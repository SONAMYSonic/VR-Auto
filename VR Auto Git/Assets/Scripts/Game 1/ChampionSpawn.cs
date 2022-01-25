using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionSpawn : MonoBehaviour
{
    public GameObject[] ChampionList;
    static public int ChampNum = 999;
    public Transform[] SpawnerPosition;

    public GameObject[] ChampionArray = new GameObject[9];

    int champCount = 0;  //챔피언 배열 세는 변수

    // Start is called before the first frame update
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        switch (ChampNum)
        {
            case 0:
                Instantiate(ChampionList[0], SpawnerPosition[0].position, transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 1:
                Instantiate(ChampionList[1], SpawnerPosition[1].position, transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 2:
                Instantiate(ChampionList[2], SpawnerPosition[2].position, transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            default:
                break;
        }
    }

    //Add Champion to Array
    public void AddChampionToArray()
    {

        if(ChampionArray[champCount] == null)
        {
            ChampionArray[champCount] = ChampionList[ChampNum];
            champCount++;
            if(champCount >= 10)
            {
                champCount = 0;
            }
        }

    }

}
