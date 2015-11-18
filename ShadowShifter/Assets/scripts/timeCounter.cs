using UnityEngine;
using System.Collections;
 
using UnityEngine.UI;

public class timeCounter : MonoBehaviour {

	static float timeLimit = 0.0f; // 10 seconds.
	public static float timeResult = 0.0f; // 10 seconds.



	//public Text resultText;

	// Use this for initialization
	void Start () {
		//if(resultText!=null)
		//resultText.text = "Works";
	}
	
	void Update()
	{
		// translate object for 10 seconds.
		if(timeLimit > -1) {
			// Decrease timeLimit.
			timeLimit += Time.deltaTime;
			//Debug.Log(timeLimit);
			if(Application.loadedLevelName =="final"){
				//Debug.Log(timeLimit);
				timeResult = timeLimit;
				//freezing time
				timeLimit =-2.0f;
				if(timeResult<15.0f){
					//Debug.Log(timeLimit);
					//Debug.Log("time from timeCounter script is: "+timeResult);
					Debug.Log("that is a really good time");
				}
				else{
					//Debug.Log(timeLimit);
					//Debug.Log(timeResult);
					Debug.Log("that is a really bad time");
					}
			}
		}
	} 


}