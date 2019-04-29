using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int mapSizeX = 10;
    public int mapSizeY = 10;

    public int[] player1StartPos = new int[2];
    public int[] player2StartPos = new int[2];

    public GameObject[,] Map;

    public GridType[] gridType;

    public GameObject player1;
    public GameObject player2;

    public bool firstplayer = true;


    // Start is called before the first frame update
    void Start()
    {
        Map = new GameObject[mapSizeX,mapSizeY];
        GenerateMap();
        GeneratePlayers();

    }

    void GenerateMap()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                Map[x, y] = (GameObject)Instantiate(gridType[0].VisualPrefab, new Vector2(x, y), Quaternion.identity);
                Map[x, y].GetComponent<Type>().type = gridType[0];


                if (Map[x, y].GetComponent<Type>().type.clickable)
                {
                    OnClick oc = Map[x, y].GetComponent<OnClick>();
                    oc.posX = x;
                    oc.posY = y;
                    oc.gameManager = this;
                }
            }
        }
    }

    void GeneratePlayers()
    {
        Map[player1StartPos[0]-1, player1StartPos[1]-1].GetComponent<Type>().type = gridType[2];
        player1 = Instantiate(player1, Map[player1StartPos[0]-1, player1StartPos[1]-1].transform.position, Quaternion.identity);
        player1.GetComponent<PlayerPos>().playerX = player1StartPos[0]-1;
        player1.GetComponent<PlayerPos>().playerY = player1StartPos[1]-1;


        Map[player2StartPos[0] - 1, player2StartPos[1] - 1].GetComponent<Type>().type = gridType[2];
        player2 = Instantiate(player2, Map[player2StartPos[0] - 1, player2StartPos[1] - 1].transform.position, Quaternion.identity);
        player2.GetComponent<PlayerPos>().playerX = player2StartPos[0] - 1;
        player2.GetComponent<PlayerPos>().playerY = player2StartPos[1] - 1;
    }

    public void MovePlayer(int x, int y)
    {
        if (firstplayer)
        {
            Map[player1.GetComponent<PlayerPos>().playerX, player1.GetComponent<PlayerPos>().playerY].GetComponent<Type>().type = gridType[0];
            player1.GetComponent<PlayerPos>().playerX = x;
            player1.GetComponent<PlayerPos>().playerY = y;

            player1.transform.position = Map[x, y].transform.position;
            Map[x, y].GetComponent<Type>().type = gridType[2];
            firstplayer = false;
        }
        else
        {
            Map[player2.GetComponent<PlayerPos>().playerX, player2.GetComponent<PlayerPos>().playerY].GetComponent<Type>().type = gridType[0];
            player2.GetComponent<PlayerPos>().playerX = x;
            player2.GetComponent<PlayerPos>().playerY = y;

            player2.transform.position = Map[x, y].transform.position;
            Map[x, y].GetComponent<Type>().type = gridType[2];
            firstplayer = true;
        }
    }
}
