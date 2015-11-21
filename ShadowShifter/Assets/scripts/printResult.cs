using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class printResult : MonoBehaviour {
	public Text resultText;
	public Text timeResult;


	float printerTime = timeCounter.timeResult;

	void Start () {
		if(resultText!=null)
		resultText.text = "result";
		//print (resultText);

		if(timeResult!=null)
			resultText.text = "time";

	}
	
	// Update is called once per frame
	void Update () {

		printerTime = timeCounter.timeResult;
		//tester ();
	}
	/*void tester(){

		if(printerTime<2.0f){
			Debug.Log("less than 2 seconds: "+printerTime);
		}
		if(printerTime > 2.0f){
			Debug.Log("more than 2 seconds: "+printerTime);	
		}


	}*/


	void OnGUI(){
		
		if(Application.loadedLevelName =="final"){

			timeResult.text = printerTime + " was your time";

			if(printerTime < 20.0f){
				resultText.text = "Nice! keep improving";
			}
			if(printerTime > 20.0f){
				
				resultText.text = "Sorry but you kind of suck!!";
			}
		}
		
	}



}

