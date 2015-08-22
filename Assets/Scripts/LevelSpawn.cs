using UnityEngine;
using System.Collections;

public class LevelSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float xPos = 0f;
		float zPos = 0f;
		float yPos = 1f;

		bool hasGap = false;
		float rand = 0f;

		for (int i = 0; i < 30; i++) {
			Instantiate(Resources.Load("Prefabs/Road"), new Vector3(xPos, yPos, zPos), Quaternion.identity);

			if(Random.value > 0.1f){
				xPos += 5f;
				zPos += 5f;
			} else {
				rand = Random.Range(10, 15);
				xPos += rand;
				zPos += rand;
			}

			yPos = (Random.Range(15, 31) / 10f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
