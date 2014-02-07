using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
		public GameObject flock;
		public GameObject health1;
		public GameObject health2;
		public GameObject health3;
		public GameObject health4;
		public GameObject health5;
		public GameObject health6;
		public GameObject health7;
		public GameObject light;
		public Color selectedColor;
		public Color deselectedColor;

		public float movementSpeed = 1.0f;

		public int health = 7;
		public int position;

		private bool dead = false;
		public bool selected = false;
		public bool allowClick = true;


		private Vector3 movement = new Vector3 (0.0f, 0.0f, 0.0f);
	
		// Use this for initialization
		void Start ()
		{
				flock = GameObject.Find ("Flock");
		}
	
		// Update is called once per frame
		void Update ()
		{
				Debug.Log ("allowClick: " + allowClick);
				if (health < 7) {
						health7.SetActive (false);
				} else {
						health7.SetActive (true);
				}

				if (health < 6) {
						health6.SetActive (false);
				} else {
						health6.SetActive (true);
				}

				if (health < 5) {
						health5.SetActive (false);
				} else {
						health5.SetActive (true);
				}

				if (health < 4) {
						health4.SetActive (false);
				} else {
						health4.SetActive (true);
				}

				if (health < 3) {
						health3.SetActive (false);
				} else {
						health3.SetActive (true);
				}

				if (health < 2) {
						health2.SetActive (false);
				} else {
						health2.SetActive (true);
				}

				if (health < 1) {
						health1.SetActive (false);
				} else {
						health1.SetActive (true);
				}

				if (selected == (true)) {
						gameObject.renderer.material.SetColor ("_Color", selectedColor);
				} else {
						gameObject.renderer.material.SetColor ("_Color", deselectedColor);
				}
		}

		public void OnTriggerEnter (Collider  otherCollider)
		{
		
				if (otherCollider.gameObject.name.Contains ("Forward")) {
						position = 1;
				}
		
				if (otherCollider.gameObject.name.Contains ("Middle")) {
						position = 2;
				}
		
				if (otherCollider.gameObject.name.Contains ("Rear")) {
						position = 3;
				}
		}
		public void ChangeHealth ()
		{
				if ((position == 1) && (health <= 7)) {
						health = health - 1;
				}

				if ((position == 2) && (health <= 7)) {
				}

				if ((position == 3) && (health <= 7)) {
						health = health + 1;
				}
		}
		void OnMouseOver ()
		{
				light.SetActive (true);

				if (allowClick == (true)) {
						
						if ((Input.GetMouseButtonDown (0))) {
								selected = !selected;
								allowClick = false;
								if (selected == (true)) {
										flock.GetComponent<Flock> ().ToggleBirdSelected (gameObject.transform.name);
								} else {
										flock.GetComponent<Flock> ().ToggleBirdSelected (null);
								}
						}
				}
		}



		void OnMouseExit ()
		{
				light.SetActive (false);
				allowClick = true;

		}

		public void AllowClick ()
		{
				allowClick = true;
		}
	

}

