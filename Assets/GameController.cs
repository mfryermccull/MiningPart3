using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject cubePrefab;

	float spawnSilverTime = 12.0f;
	float spawnFrequency = 3f;
	float timeToAct = 0f;
	float stopSpawningTime = 6.0f;

	// Use this for initialization
	void Start () {
		timeToAct += spawnFrequency;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Time.time >= timeToAct && Time.time < spawnSilverTime + stopSpawningTime){
			GameObject myCube = (GameObject) Instantiate(cubePrefab,
			           new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
			           Quaternion.identity);

			if (Time.time >= spawnSilverTime) {
				myCube.GetComponent<Renderer>().material.color = Color.white;
			}
			else {
				myCube.GetComponent<Renderer>().material.color = Color.red;
			}

			timeToAct += spawnFrequency;
			print ("spawnACube");
			print (Time.time);

			timeToAct += spawnFrequency;
		}


	}
}
