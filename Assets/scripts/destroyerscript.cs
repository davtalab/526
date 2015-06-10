using UnityEngine;
using System.Collections;

public class destroyerscript : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other)
	{
				if (other.tag == "Player") {
						Debug.Break ();
						return;
				}
				if (other.gameObject.transform.parent) {
						Destroy (other.gameObject.transform.parent.gameObject);
						//other.gameObject.transform.parent.gameObject.
						Debug.Log ("destroy parent");
				} else {
						Destroy (other.gameObject);
						Debug.Log ("destroy ");

				}
		}
}

