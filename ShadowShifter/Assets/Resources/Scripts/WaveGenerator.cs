using UnityEngine;
using System.Collections;

public class WaveGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {

		SpawnWave();
		
		/*GameObject lightGameObject = new GameObject("The Light");
        Light lightComp = lightGameObject.AddComponent<Light>();
        lightComp.color = Color.blue;
		lightComp.intensity = 15;

		
        lightGameObject.transform.position = new Vector3 (0,0, 2);	
        lightGameObject.transform.Rotate(90, 0, 0);  
		*/
	}

	
	
	void SpawnWave() {
		//GameObject obj = Instantiate(Resources.Load("Prefabs/Cube")) as GameObject;
		GameObject cubexObj = Instantiate(Resources.Load("Prefabs/cubex2")) as GameObject;

		//obj.transform.position = new Vector3(0, 0, 7);
		//Rigidbody [] children = obj.GetComponentsInChildren<Rigidbody>();
	    //children[0].constraints = RigidbodyConstraints.FreezePosition;
		
		cubexObj.transform.position = new Vector3(-3.25f, -0.52f, 8.22f);
		cubexObj.transform.localScale = new Vector3(0.03F, 0.03F, 0.03F);	
		Rigidbody [] children2 = cubexObj.GetComponentsInChildren<Rigidbody>();
	    children2[0].constraints = RigidbodyConstraints.FreezePosition;

	}
	
	
	
	
	
}