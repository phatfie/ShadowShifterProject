using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class printResult : MonoBehaviour {
	public Text resultText;

	float printerTime = timeCounter.timeResult;

	void Start () {
		if(resultText!=null)
		resultText.text = "Works";
		print (resultText);
	}
	
	// Update is called once per frame
	void Update () {

		printerTime = timeCounter.timeResult;
		tester ();
	}
	void tester(){

		if(printerTime<2.0f){
			Debug.Log("less than 2 seconds: "+printerTime);
		}
		if(printerTime > 2.0f){
			Debug.Log("more than 2 seconds: "+printerTime);	
		}


	}


	void OnGUI(){
		
		if(Application.loadedLevelName =="final"){

			if(printerTime < 20.0f){
				resultText.text = "You are the best player ever!!";
			}
			if(printerTime > 20.0f){
				
				resultText.text = "You kind of suck!!";
			}
		}
		
	}



}

