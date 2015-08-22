using UnityEngine;
using System.Collections;

public class LevelSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SpawnRoadChunk (300);
	}

	void SpawnRoadChunk(int road) {
		float xPos = 0f;
		float zPos = 0f;
		float yPos = 1f;
		
		bool hasGap = false;
		float rand = 0f;
		
		for (int i = 0; i < road; i++) {
			Instantiate(Resources.Load("Prefabs/Road"), new Vector3(xPos, yPos, zPos), Quaternion.identity);

			if(Random.value > 0.5f){
				xPos +=5f;
			} else {
				zPos +=5f;
			}

			/*
			if(Random.value > 0.5f){
				yPos += (Random.Range(0,6) / 10f);
			} else {
				yPos -= (Random.Range (0,6) / 10f);
			}
			*/
		}
	}
}
