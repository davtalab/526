using UnityEngine;
using System.Collections;

public class xx : MonoBehaviour {
	public GameObject  predatorPast;
	public LayerMask whatIsDetector; 
	//	bool isdetected = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		//Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Player") {
			//GameObject destroyedCarGameObject = (GameObject)Instantiate(destroyedCarPrefab, carGameObject.transform.position, carGameObject.transform.rotation);
			//Instantiate(predatorPast,transform.position,Quaternion.identity);
			//gameObject. renderer.enabled = false;
			
			Destroy(other.gameObject);
			
			
		}
		
	}
	void FixedUpdate () {
		
		//isdetected = Physics2D.OverlapCircle (transform.position, 10f, whatIsDetector);
		//Debug.Log (isdetected);
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	public int ChangeToPast()
	{
		Instantiate(predatorPast,transform.position,Quaternion.identity);
		
		
		Destroy(gameObject);
		return 1;
		
	}
}
