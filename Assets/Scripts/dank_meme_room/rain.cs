using UnityEngine;
using System.Collections;

public class rain : MonoBehaviour {

	private GameObject spawnPoint;
	private int counter;

	// Use this for initialization
	void Start () {
		spawnPoint = GameObject.Find ("SpawnPoint");
		counter = 1;

		while (counter < 30) {
			//Invoke ("Rain", 2f);
			Rain ();
			counter++;
		}

	}
	
	// Update is called once per frame
	void Update () {
	}

	void Rain() {
		Instantiate(Resources.Load("Prefabs/dank_memes/Kappa"), new Vector3(Random.Range(-80f, 80f), Random.Range(14f, 55f), Random.Range(4f, 6f)) , Quaternion.Euler(0, 180,0));
	}
}
