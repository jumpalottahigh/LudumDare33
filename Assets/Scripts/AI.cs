using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (player.transform.position * Time.deltaTime);
	}
}
