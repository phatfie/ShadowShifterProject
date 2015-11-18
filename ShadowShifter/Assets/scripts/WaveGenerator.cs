using UnityEngine;
using System.Collections;

public class WaveGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {

		SpawnWave();

	}

	void SpawnWave() {

		if(Application.loadedLevelName =="level_01"){
			//GameObject obj = Instantiate(Resources.Load("Prefabs/Cube")) as GameObject;
			GameObject cubeObj1 = Instantiate(Resources.Load("Prefabs/cube1")) as GameObject;

			cubeObj1.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj1.transform.localScale = new Vector3(0.03F, 0.03F, 0.03F);	
			Rigidbody [] children = cubeObj1.GetComponentsInChildren<Rigidbody>();
			children[0].constraints = RigidbodyConstraints.FreezePosition;

		}

		if(Application.loadedLevelName =="level_02"){
			GameObject cubeObj2 = Instantiate(Resources.Load("Prefabs/cube2")) as GameObject;

			//cubexObj.transform.position = new Vector3(-3.25f, -0.52f, 8.22f);
			cubeObj2.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj2.transform.localScale = new Vector3(0.03F, 0.03F, 0.03F);	
			Rigidbody [] children2 = cubeObj2.GetComponentsInChildren<Rigidbody>();
			children2[0].constraints = RigidbodyConstraints.FreezePosition;
			
		}

		if(Application.loadedLevelName =="level_03"){
			GameObject cubeObj3 = Instantiate(Resources.Load("Prefabs/cube3")) as GameObject;
			
			//cubexObj.transform.position = new Vector3(-3.25f, -0.52f, 8.22f);
			cubeObj3.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj3.transform.localScale = new Vector3(0.03F, 0.03F, 0.03F);	
			Rigidbody [] children3 = cubeObj3.GetComponentsInChildren<Rigidbody>();
			children3[0].constraints = RigidbodyConstraints.FreezePosition;
			
		}

		if(Application.loadedLevelName =="level_04"){
			GameObject cubeObj4 = Instantiate(Resources.Load("Prefabs/cube4")) as GameObject;
			cubeObj4.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj4.transform.localScale = new Vector3(0.03F, 0.03F, 0.03F);	
			Rigidbody [] children4 = cubeObj4.GetComponentsInChildren<Rigidbody>();
			children4[0].constraints = RigidbodyConstraints.FreezePosition;
			
		}

		if(Application.loadedLevelName =="level_05"){
			GameObject cubeObj5 = Instantiate(Resources.Load("Prefabs/cube5")) as GameObject;
			cubeObj5.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj5.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);	
			Rigidbody [] children5 = cubeObj5.GetComponentsInChildren<Rigidbody>();
			children5[0].constraints = RigidbodyConstraints.FreezePosition;

		}

		if(Application.loadedLevelName =="level_06"){
			GameObject cubeObj6 = Instantiate(Resources.Load("Prefabs/cube6")) as GameObject;
			cubeObj6.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj6.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);	
			Rigidbody [] children6 = cubeObj6.GetComponentsInChildren<Rigidbody>();
			children6[0].constraints = RigidbodyConstraints.FreezePosition;
			
		}


		if(Application.loadedLevelName =="level_07"){
			GameObject cubeObj7 = Instantiate(Resources.Load("Prefabs/cube7")) as GameObject;
			cubeObj7.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj7.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);	
			Rigidbody [] children7 = cubeObj7.GetComponentsInChildren<Rigidbody>();
			children7[0].constraints = RigidbodyConstraints.FreezePosition;
			
		}


		if(Application.loadedLevelName =="level_08"){
			GameObject cubeObj8 = Instantiate(Resources.Load("Prefabs/cube8")) as GameObject;
			cubeObj8.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj8.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);	
			Rigidbody [] children8 = cubeObj8.GetComponentsInChildren<Rigidbody>();
			children8[0].constraints = RigidbodyConstraints.FreezePosition;
			
		}


		if(Application.loadedLevelName =="level_09"){
			GameObject cubeObj9 = Instantiate(Resources.Load("Prefabs/cube9")) as GameObject;
			cubeObj9.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj9.transform.localScale = new Vector3(0.08F, 0.08F, 0.08F);	
			Rigidbody [] children9 = cubeObj9.GetComponentsInChildren<Rigidbody>();
			children9[0].constraints = RigidbodyConstraints.FreezePosition;
			
		}
		if(Application.loadedLevelName =="level_10"){
			GameObject cubeObj10 = Instantiate(Resources.Load("Prefabs/cube10")) as GameObject;
			cubeObj10.transform.position = new Vector3 (-4.5f, -0.52f, 10.302f);
			
			cubeObj10.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);	
			Rigidbody [] children10 = cubeObj10.GetComponentsInChildren<Rigidbody>();
			children10[0].constraints = RigidbodyConstraints.FreezePosition;
			
		}


	}
	
}