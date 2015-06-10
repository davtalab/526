using UnityEngine;
using System.Collections;

public class egg : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		//Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Player") {
			//GameObject destroyedCarGameObject = (GameObject)Instantiate(destroyedCarPrefab, carGameObject.transform.position, carGameObject.transform.rotation);
			//Instantiate(predatorPast,transform.position,Quaternion.identity);
			//gameObject. renderer.enabled = false;
			Debug.Log ("egg");
			Destroy(gameObject);
			
			
		}
		
	}
}
