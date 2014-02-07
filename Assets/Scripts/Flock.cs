using UnityEngine;
using System.Collections;

public class Flock : MonoBehaviour
{

		private Vector3 movement = new Vector3 (0.0f, 0.0f, 0.0f);
		public float movementSpeed = 1.0f;
		public int health = 7;
		public GameObject bird1;
		public GameObject bird2;
		public GameObject bird3;
		public GameObject bird4;
		public GameObject bird5;
		public bool triggered = false;
		public bool birdSelected;
		public string specificBirdSelected;


		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				Debug.Log ("Specific Bird Selected: " + specificBirdSelected);

				//Movement
				movement = Vector3.up * movementSpeed * Time.deltaTime;
				gameObject.transform.Translate (movement);

				if (specificBirdSelected == ("Bird1")) {
						bird2.gameObject.GetComponent<Bird> ().allowClick = false;
						bird3.gameObject.GetComponent<Bird> ().allowClick = false;
						bird4.gameObject.GetComponent<Bird> ().allowClick = false;
						bird5.gameObject.GetComponent<Bird> ().allowClick = false;
				}

				if (specificBirdSelected == ("Bird2")) {
						bird1.gameObject.GetComponent<Bird> ().allowClick = false;
						bird3.gameObject.GetComponent<Bird> ().allowClick = false;
						bird4.gameObject.GetComponent<Bird> ().allowClick = false;
						bird5.gameObject.GetComponent<Bird> ().allowClick = false;
				}

				if (specificBirdSelected == ("Bird3")) {
						bird2.gameObject.GetComponent<Bird> ().allowClick = false;
						bird1.gameObject.GetComponent<Bird> ().allowClick = false;
						bird4.gameObject.GetComponent<Bird> ().allowClick = false;
						bird5.gameObject.GetComponent<Bird> ().allowClick = false;
				}

				if (specificBirdSelected == ("Bird4")) {
						bird2.gameObject.GetComponent<Bird> ().allowClick = false;
						bird3.gameObject.GetComponent<Bird> ().allowClick = false;
						bird1.gameObject.GetComponent<Bird> ().allowClick = false;
						bird5.gameObject.GetComponent<Bird> ().allowClick = false;
				}

				if (specificBirdSelected == ("Bird5")) {
						bird2.gameObject.GetComponent<Bird> ().allowClick = false;
						bird3.gameObject.GetComponent<Bird> ().allowClick = false;
						bird4.gameObject.GetComponent<Bird> ().allowClick = false;
						bird1.gameObject.GetComponent<Bird> ().allowClick = false;
				}
		}

		void OnTriggerEnter (Collider  otherCollider)
		{
				if ((otherCollider.gameObject.name.Contains ("ReductionZone")) && (triggered == false)) {
						bird1.gameObject.GetComponent<Bird> ().ChangeHealth ();
						bird2.gameObject.GetComponent<Bird> ().ChangeHealth ();
						bird3.gameObject.GetComponent<Bird> ().ChangeHealth ();
						bird4.gameObject.GetComponent<Bird> ().ChangeHealth ();
						bird5.gameObject.GetComponent<Bird> ().ChangeHealth ();
						triggered = true;
				}				
		}

		void OnTriggerExit (Collider otherCollider)
		{
				if (otherCollider.gameObject.name.Contains ("ReductionZone")) {
						triggered = false;

				}		
		}

		public void ToggleBirdSelected (string birdName)
		{
				birdSelected = !birdSelected;
				specificBirdSelected = birdName;
		}
	
}
