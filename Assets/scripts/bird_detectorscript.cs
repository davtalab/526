using UnityEngine;
using System.Collections;

public class bird_detectorscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter2D (Collider2D other)
	{
		
		Debug.Log (other.tag);
		if( other.tag == "predator")
		{
			xx x = other.gameObject.GetComponent<xx>();
			x.ChangeToPast();
			// x.ChangeToPast();
		}
		
	}
}
