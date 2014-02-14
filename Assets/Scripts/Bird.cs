using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
		public GameObject flock;
		public GameObject position3;
		public GameObject position1;
		public GameObject position2;
		public GameObject position4;
		public GameObject position5;
		public GameObject health1;
		public GameObject health2;
		public GameObject health3;
		public GameObject health4;
		public GameObject health5;
		public GameObject health6;
		public GameObject health7;
		public GameObject light;
		public Color highlightedColor;
		public Color selectedColor;
		public Color deselectedColor;
		public int birdNumber;

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
				position1 = GameObject.Find ("position1");
				position2 = GameObject.Find ("position2");
				position3 = GameObject.Find ("position3");
				position4 = GameObject.Find ("position4");
				position5 = GameObject.Find ("position5");
	

		}
	
		// Update is called once per frame
		void Update ()
		{
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
		
//				if (otherCollider.gameObject.name.Contains ("Forward")) {
//						position = 1;
//				}
//		
//				if (otherCollider.gameObject.name.Contains ("Middle")) {
//						position = 2;
//				}
//		
//				if (otherCollider.gameObject.name.Contains ("Rear")) {
//						position = 3;
//				}

				if (otherCollider.gameObject.name.Contains ("position1")) {
						position = 1;
				}

				if (otherCollider.gameObject.name.Contains ("position2")) {
						position = 2;
				}

				if (otherCollider.gameObject.name.Contains ("position3")) {
						position = 3;
						flock.GetComponent<Flock> ().SetBirdInLeadPosition (birdNumber);
				}

				if (otherCollider.gameObject.name.Contains ("position4")) {
						position = 4;
				}

				if (otherCollider.gameObject.name.Contains ("position5")) {
						position = 5;
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
										flock.GetComponent<Flock> ().SetVacatedPosition (position);
										flock.GetComponent<Flock> ().moveLeadBirdToVacatedPosition ();
										//flock.GetComponent<Flock> ().SetBirdInLeadPosition (birdNumber);
										MoveToLeadPosition ();
										flock.GetComponent<Flock> ().UnselectAllBirds ();
										selected = false;
										flock.GetComponent<Flock> ().ToggleBirdSelected (null);






								} else {
										flock.GetComponent<Flock> ().ToggleBirdSelected (null);
								}
						}
				}
		}

		void OnMouseEnter ()
		{
				gameObject.renderer.material.SetColor ("_Color", highlightedColor);

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

		public void MoveToPosition1 ()
		{
				iTween.MoveTo (gameObject, iTween.Hash ("position", position1.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
//				transform.position = Vector3.MoveTowards (transform.position, position1.transform.position, Time.deltaTime);

		}

		public void MoveToPosition2 ()
		{
				iTween.MoveTo (gameObject, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
//				transform.position = Vector3.MoveTowards (transform.position, position2.transform.position, Time.deltaTime);

		}

		public void MoveToLeadPosition ()
		{

				iTween.MoveTo (gameObject, iTween.Hash ("position", position3.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
//				transform.position = Vector3.MoveTowards (transform.position, leadPosition.transform.position, Time.deltaTime);

		}

		public void MoveToPosition4 ()
		{
				iTween.MoveTo (gameObject, iTween.Hash ("position", position4.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
//				transform.position = Vector3.MoveTowards (transform.position, position4.transform.position, Time.deltaTime);

		}

		public void MoveToPosition5 ()
		{
				iTween.MoveTo (gameObject, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
//				transform.position = Vector3.MoveTowards (transform.position, position5.transform.position, Time.deltaTime);

		}

}

