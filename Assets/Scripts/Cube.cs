using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
		public Color highlightedColor;
		public Color deselectedColor;
		public GameObject manager;
		public int cubeNumber;
		public int cubePosition;


		// Use this for initialization
		void Start ()
		{
				manager = GameObject.Find ("_Manager");
				gameObject.renderer.material.SetColor ("_Color", deselectedColor);

		}
	
		// Update is called once per frame
		void Update ()
		{
	
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
}
