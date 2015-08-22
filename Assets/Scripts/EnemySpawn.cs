using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 5; i++) {
			Instantiate(Resources.Load("Prefabs/Sheep"), new Vector3(Random.Range(-25, 25), 1f, Random.Range(-25,25)), Quaternion.identity);
			Instantiate(Resources.Load("Prefabs/Pigglet"), new Vector3(Random.Range(-25, 25), 1f, Random.Range(-25,25)), Quaternion.identity);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
