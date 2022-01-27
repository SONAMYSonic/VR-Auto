using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampionSpawn : MonoBehaviour
{
    public GameObject[] ChampionList;
    public static int ChampNum = 999;
    public Transform[] SpawnerPosition;

    public GameObject[] ChampionArray = new GameObject[9];
    public bool[] ChampionBool = new bool[9];

    int champCount;
    //è�Ǿ� �迭 ���� ����
    public bool youCantBuy;
    //è�Ǿ��� ����ִ� ����� ��!

    public int[] shopUnit = new int[5];  //������ � ������ �ֳ� üũ�ϴ� �迭


    public void championSpawn(int i)
    {
        switch (i)
        {
            case 0:
                ChampNum = shopUnit[0];
                break;
            case 1:
                ChampNum = shopUnit[1];
                break;
            case 2:
                ChampNum = shopUnit[2];
                break;
            case 3:
                ChampNum = shopUnit[3];
                break;
            case 4:
                ChampNum = shopUnit[4];
                break;
            default:
                break;
        }

        switch (ChampNum)
        {
            case 0:
                Instantiate(ChampionList[0], SpawnerPosition[champCount].position, ChampionList[0].transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 1:
                Instantiate(ChampionList[1], SpawnerPosition[champCount].position, ChampionList[1].transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 2:
                Instantiate(ChampionList[2], SpawnerPosition[champCount].position, ChampionList[2].transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 3:
                Instantiate(ChampionList[3], SpawnerPosition[champCount].position, ChampionList[3].transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 4:
                Instantiate(ChampionList[4], SpawnerPosition[champCount].position, ChampionList[4].transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 5:
                Instantiate(ChampionList[5], SpawnerPosition[champCount].position, ChampionList[5].transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 6:
                Instantiate(ChampionList[6], SpawnerPosition[champCount].position, ChampionList[6].transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 7:
                Instantiate(ChampionList[7], SpawnerPosition[champCount].position, ChampionList[7].transform.rotation);
                AddChampionToArray();
                ChampNum = 999;
                break;
            case 8:
                Instantiate(ChampionList[8], SpawnerPosition[champCount].position, ChampionList[8].transform.rotation);
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
        int temp;
        if(ChampionArray[champCount] == null)
        {
            ChampionArray[champCount] = ChampionList[ChampNum];
            champCount++;
            if(champCount > 8)
            {
                champCount = 0;
            }
        }
        else if(ChampionArray[champCount] != null)
        {
            temp = champCount;
            while (true)
            {
                champCount++;
                if(champCount > 8)
                {
                    champCount = 0;
                }

                if(ChampionArray[champCount] == null)
                {
                    ChampionArray[champCount] = ChampionList[ChampNum];
                    champCount++;
                    break;
                }

                if(champCount == temp)
                {
                    Debug.Log("�縸");
                    youCantBuy = true;
                    //ĳ���� ���� â�� �� �� ��
                    break;
                }
            }
        }
        
    }

}
