using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	cell[,] cells;
	public int gridWidth;
	public int gridHeight;
	public GameObject cellObject;

	// Use this for initialization
	void Start () {

		GenerateMap();
		for (int i = 0; i < gridWidth; i++){
			for (int j = 0; j < gridHeight; j++){
				Instantiate (cellObject, new Vector3(i, j, 0), Quaternion.identity);
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GenerateMap()
	{
		cells = new cell[gridWidth, gridHeight];
		//nested for loop
		for(int i = 0; i < gridWidth; i++)
		{
			for (int j = 0; j < gridHeight; j++)
			{
				cells[i,j].xPos = i;
				cells[i,j].yPos = j;
			}
		}
	}



}

public struct cell
{
	public int xPos;
	public int yPos;
	public bool canHaveTower;
}
