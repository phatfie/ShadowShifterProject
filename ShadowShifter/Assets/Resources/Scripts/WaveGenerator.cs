using UnityEngine;
using System.Collections;

public class WaveGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {

		SpawnWave();
	}

	void SpawnWave() {
		GameObject obj = Instantiate(Resources.Load("Prefabs/Cube")) as GameObject;
		obj.transform.position = new Vector3(0, 0, 7);
		Rigidbody [] children = obj.GetComponentsInChildren<Rigidbody>();
	    children[0].constraints = RigidbodyConstraints.FreezePosition;

	}
	
}
