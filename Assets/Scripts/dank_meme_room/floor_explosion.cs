using UnityEngine;
using System.Collections;

public class floor_explosion : MonoBehaviour {

	private GameObject test;

	void OnTriggerEnter (Collider other){
		test = Instantiate (Resources.Load ("Prefabs/dank_memes/Explosion"), other.gameObject.transform.position, Quaternion.identity) as GameObject;
		Destroy (other.gameObject);
		Destroy (test, 2f);
	}
	
}
