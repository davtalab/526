using UnityEngine;
using System.Collections;

public class effect_callback : MonoBehaviour {
	public bool end = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void effctent(bool theValue)
	{
		end = theValue;
		}
}
