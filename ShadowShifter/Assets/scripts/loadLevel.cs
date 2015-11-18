using UnityEngine;
using System.Collections;

public class loadLevel : MonoBehaviour {

	public string nextLevel;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		leveler ();

	}


	void leveler(){

	if(Input.GetKeyDown(KeyCode.Space)) 
		Application.LoadLevel(nextLevel);

	}

}
