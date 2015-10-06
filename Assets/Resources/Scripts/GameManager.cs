using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	[SerializeField]
	GameObject[] cubes = new GameObject[3];
	[SerializeField]
	GameObject spawnPoint;

	Vector3 spawnPos;
	int cubeType;
	// Use this for initialization
	void Start () 
	{
		spawnPos = spawnPoint.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonUp (0))
		{
			Vector3 cubeBirthPoint = new Vector3(Random.Range(spawnPos.x -2.5f,spawnPos.x+2.5f),spawnPos.y,Random.Range(spawnPos.z -2.5f,spawnPos.z+2.5f));
			cubeType = Random.Range(0,3);
			Vector3 cubeRot = new Vector3(Random.Range(-180,180),Random.Range(-180,180),Random.Range(-180,180));
			GameObject c = Instantiate(cubes[cubeType],cubeBirthPoint,Quaternion.Euler(cubeRot))as GameObject;
			c.AddComponent<CubeOperator>();
		}
	}
}
