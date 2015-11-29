using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class scoring : MonoBehaviour {

	public static int score = 0;
	public Text finalResult;

	void Start () {
		if(finalResult!=null)
			finalResult.text = "WORKS!";
		
	}


	void Update() {
			incremental ();
		}
	void incremental(){

			if ((Application.loadedLevelName == "test_01")){
			score = 0;
				
				if (Input.GetKeyDown ("a")) {
						print ("A key was pressed");
						score = score + 20;
						Debug.Log (score);
						Application.LoadLevel (14);
				
				}

			if ( Input.GetKeyDown ("b") || Input.GetKeyDown ("c") || Input.GetKeyDown ("d")) {
					print ("wrong");
					Debug.Log (score);
					Application.LoadLevel (14);
				
			}		

		}

		if ((Application.loadedLevelName == "test_02")){
			
			if (Input.GetKeyDown ("d")) {
				print ("D key was pressed");
				score = score + 20;
				Debug.Log (score);
				Application.LoadLevel (15);
				
			}
			
			if ( Input.GetKeyDown ("a") || Input.GetKeyDown ("b") || Input.GetKeyDown ("c") ) {
				print ("wrong");
				Debug.Log (score);
				Application.LoadLevel (15);
				
			}		
		}	


		if ((Application.loadedLevelName == "test_03")){
			
			if (Input.GetKeyDown ("b")) {
				print ("B key was pressed");
				score = score + 20;
				Debug.Log (score);
				Application.LoadLevel (16);
				
			}
			
			if ( Input.GetKeyDown ("a") || Input.GetKeyDown ("c") || Input.GetKeyDown ("d") ) {
				print ("wrong");
				Debug.Log (score);
				Application.LoadLevel (16);
				
			}		
			
			
		}	
		if ((Application.loadedLevelName == "test_04")){
			
			if (Input.GetKeyDown ("c")) {
				print ("C key was pressed");
				score = score + 20;
				Debug.Log (score);
				Application.LoadLevel (17);
				
			}
			
			if ( Input.GetKeyDown ("a") || Input.GetKeyDown ("b") || Input.GetKeyDown ("d") ) {
				print ("wrong");
				Debug.Log (score);
				Application.LoadLevel (17);
				
			}		

		}	

		if ((Application.loadedLevelName == "test_05")){
			
			if (Input.GetKeyDown ("b")) {
				print ("B key was pressed");
				score = score + 20;
				Debug.Log (score);
				Application.LoadLevel (18);
				
			}
			
			if ( Input.GetKeyDown ("a") || Input.GetKeyDown ("c") || Input.GetKeyDown ("d") ) {
				print ("wrong");
				Debug.Log (score);
				Application.LoadLevel (18);
				
			}		

			
		}

		if ((Application.loadedLevelName == "finalTest")){
			Debug.Log("FINAL LEVEL");
			finalResult.text = score.ToString()+ " /100" ;

						
		}


	}
}