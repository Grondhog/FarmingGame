using UnityEngine;
using System.Collections;

public class MapGeneration : MonoBehaviour {

	private const char GRASS = 'G';
	private const char DIRT = 'D';

	private int width = 4;
	private int height = 4;

	[SerializeField]
	private GameObject grassTile;

	[SerializeField]
	private GameObject dirtTile;

	private char[,] map;

	void Start () {
		map = new char[,]{
			{GRASS, GRASS, GRASS, GRASS},
			{GRASS, GRASS, GRASS, GRASS},
			{GRASS, GRASS, DIRT, DIRT},
			{GRASS, GRASS, DIRT, DIRT}
		};
		GenerateMap();
	}

	private void GenerateMap()
	{
		GameObject temp = new GameObject();
		for(int i = 0; i < width; i++)
		{
			for(int j = 0; j < height; j++)
			{
				switch(map[i,j])
				{
					case GRASS:
						temp = Instantiate(grassTile, new Vector3(i, 0, j), Quaternion.identity) as GameObject;
						break;
					case DIRT:
						temp = Instantiate(dirtTile, new Vector3(i, 0, j), Quaternion.identity) as GameObject;
						break;
				}
				//temp.transform.parent = this.transform;
			}
		}
	}
}

