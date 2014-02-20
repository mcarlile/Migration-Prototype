using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
		public Color highlightedColor;
		public Color deselectedColor;
		public GameObject manager;
		public int cubeNumber;
		public int cubePosition;
		public int health = 7;
		public GameObject health1;
		public GameObject health2;
		public GameObject health3;
		public GameObject health4;
		public GameObject health5;
		public GameObject health6;
		public GameObject health7;
	
	
	// Use this for initialization
		void Start ()
		{
				manager = GameObject.Find ("_Manager");
				gameObject.renderer.material.SetColor ("_Color", deselectedColor);

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
			
			if (health <= 1) {
				health1.SetActive (false);
			} else {
				health1.SetActive (true);
			}
	}
	
	void OnMouseOver ()
	{
		gameObject.renderer.material.SetColor ("_Color", highlightedColor);
				if ((Input.GetMouseButtonDown (0))) {
						manager.GetComponent<Manager> ().MoveCubeToFront (cubeNumber, cubePosition);
				}
		}

		void OnMouseExit ()
		{
				gameObject.renderer.material.SetColor ("_Color", deselectedColor);
		}

		public void SetPosition (int newPosition)
		{
				Debug.Log ("setpositioncalled");
				cubePosition = newPosition;
		}

		//Begin Health Management System

		public void ChangeHealth ()
		{
				//Birds in the back of the flock increase their health over time while birds
				//in the front of the flock decrease their health. The more close to either
				//the front or the back, the more extreme the change

				Debug.Log ("change health called");

				if (((cubePosition == 1) || (cubePosition == 9)) && (health <= 5)) {
						health = health + 2;
				}

				if (((cubePosition == 2) || (cubePosition == 8)) && (health <= 5)) {
						health = health ++;
				}

				if (((cubePosition == 3) || (cubePosition == 7)) && (health <= 5)) {
				}

				if (((cubePosition == 4) || (cubePosition == 6)) && (health <= 5)) {
						health = health --;
				}

				if ((cubePosition == 5) && (health >= 2)) {
						health = health - 2;
				}
		
	
		}
}
