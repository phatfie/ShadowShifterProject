using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class leveOutput : MonoBehaviour {
	public Text levelData;

	// Use this for initialization
	void Start () {
		if(levelData!=null)
		levelData.text = "";

	}
	
	// Update is called once per frame
	void Update () {
	}


	void OnGUI(){
		if(Application.loadedLevelName =="level_01"){
			levelData.text = "Level 1";
		}
		if(Application.loadedLevelName =="level_02"){
			levelData.text = "Level 2";
		}
		if(Application.loadedLevelName =="level_03"){
			levelData.text = "Level 3";
		}
		if(Application.loadedLevelName =="level_04"){
			levelData.text = "Level 4";
		}
		if(Application.loadedLevelName =="level_05"){
			levelData.text = "Level 5";
		}
		if(Application.loadedLevelName =="level_06"){
			levelData.text = "Level 6";
		}
		if(Application.loadedLevelName =="level_07"){
			levelData.text = "Level 7";
		}
		if(Application.loadedLevelName =="level_08"){
			levelData.text = "Level 8";									
		}
		if(Application.loadedLevelName =="level_09"){
			levelData.text = "Level 9";
		}
		if(Application.loadedLevelName =="level_10"){
			levelData.text = "Level 10";
			}
  }
}
