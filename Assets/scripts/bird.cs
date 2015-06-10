using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {
	public float maxSpeed = 90f;
	public bool movingRight = false;
	public bool movingLeft = false;
	public bool movingUp = false;
	public bool movingDown = false;
	public bool move = false;
	public GameObject field;
	public GameObject effect;

	public bool run = true;
	public bool effctOn = false;

	public GameObject detector;
	public int time = 0;


	 Animator anim;
	Animator effct_anim;
	Animator field_anim;
	int effectend;
	CircleCollider2D detectorCol;




	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		effct_anim = effect.GetComponent<Animator> ();
		field_anim = field.GetComponent<Animator> ();
		//effectend = effct_anim.currentBaseState.nameHash;
		//detectorCol = detector.GetComponent<CircleCollider2D>();
	
	}

	void Update()
	{
		/// change time
		/// 
		/// 
		if (Input.GetKey (KeyCode.Q)) {
			if(run){	
				if(time < 200)
				{
				 	transform.Translate(100f,0,0);
					time += 100;
				}
				else{
					time = 0;
					transform.Translate(-200f,0,0);

				}

				effctOn = true;
				
				anim.SetBool ("movingRight", false);
				anim.SetBool ("movingLeft", false);
				anim.SetBool ("movingUp", false);
				anim.SetBool ("movingDown", false);
				effct_anim.SetBool ("effectOn", true);
				field_anim.SetBool ("effectOn", true);
				detector.SetActive(true);

			}
			//Debug.Log(transform.position.x);
			run = false;
				
		}



		if (Input.anyKey == false) {
			run = true;
			effctOn = false;
			effct_anim.SetBool ("effectOn", false);
			field_anim.SetBool ("effectOn", false);
			//detectorCol.enabled = false;
			detector.SetActive(false);
			

				}



		if (Input.GetKey (KeyCode.Space)) {
						effctOn = true;
						anim.SetBool ("movingRight", false);
						anim.SetBool ("movingLeft", false);
						anim.SetBool ("movingUp", false);
						anim.SetBool ("movingDown", false);
						effct_anim.SetBool ("effectOn", true);
						field_anim.SetBool ("effectOn", true);
						//detectorCol.enabled = true;
						detector.SetActive(true);
				
		} else {
			effctOn = false;
			effct_anim.SetBool ("effectOn", false);
			field_anim.SetBool ("effectOn", false);
			//detectorCol.enabled = false;
			detector.SetActive(false);
		}
	}
	
	void FixedUpdate () {
		//grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		//Debug.Log(grounded);

		//anim.SetBool ("Ground", grounded);



		move = false;

		float movex = Input.GetAxis ("Horizontal");
		//Debug.Log (movex);
		float movey = Input.GetAxis ("Vertical");
		//Debug.Log (movey);
		anim.SetBool("movingRight",false);
		anim.SetBool("movingLeft",false);
		anim.SetBool("movingUp",false);
		anim.SetBool("movingDown",false);
		rigidbody2D.velocity = new Vector2 (0,0);

		if(true
		
			)
			//Do reaction
		 {

			if (Mathf.Abs (movex) > 0.1 || Mathf.Abs (movey) > 0.1 ) {
				//if(Mathf.Abs (movex) < 0.862)
								move = true;
								anim.SetBool ("move", true);
								anim.SetBool ("movingRight", false);
								anim.SetBool ("movingLeft", false);
								anim.SetBool ("movingUp", false);
								anim.SetBool ("movingDown", false);

						} else {
								move = false;
								anim.SetBool ("move", false);
						}
						//Debug.Log ("move = " + move);

						if (move == true) {
								if (Mathf.Abs (movex) > 0.1) {
										if (movex > 0) {
												anim.SetBool ("movingRight", true);
												anim.SetBool ("movingLeft", false);
												anim.SetBool ("movingUp", false);
												anim.SetBool ("movingDown", false);


										} else {
												anim.SetBool ("movingLeft", true);
												anim.SetBool ("movingRight", false);
												anim.SetBool ("movingUp", false);
												anim.SetBool ("movingDown", false);
										}
										rigidbody2D.velocity = new Vector2 (movex * maxSpeed, rigidbody2D.velocity.y);
									//	rigidbody2D.velocity = new Vector2 (8.62f, rigidbody2D.velocity.y);
								} else {

										if (Mathf.Abs (movey) > 0.1) {
												if (movey > 0) {
														anim.SetBool ("movingUp", true);
														anim.SetBool ("movingLeft", false);
														anim.SetBool ("movingRight", false);
														anim.SetBool ("movingDown", false);
												} else {
														anim.SetBool ("movingDown", true);
														anim.SetBool ("movingLeft", false);
														anim.SetBool ("movingUp", false);
														anim.SetBool ("movingRight", false);
												}
												rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, movey * maxSpeed);
				                        //		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 8.62f);
										}

								}

						}


				}


		
	}

}
