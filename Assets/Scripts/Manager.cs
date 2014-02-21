using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Manager : MonoBehaviour
{
		public GameObject cube1;
		public GameObject cube2;
		public GameObject cube3;
		public GameObject cube4;
		public GameObject cube5;
		public GameObject cube6;
		public GameObject cube7;
		public GameObject cube8;
		public GameObject cube9;
		public int cubeInFront;
		public GameObject position1;
		public GameObject position2;
		public GameObject position3;
		public GameObject position4;
		public GameObject position5;
		public GameObject position6;
		public GameObject position7;
		public GameObject position8;
		public GameObject position9;
		public float time;
		public float secondsBetweenHealthChange = 5;
		List<GameObject> birds = new List<GameObject> ();

		// Use this for initialization
		void Start ()
		{
				cubeInFront = 5;

				birds.Add (cube1);
				birds.Add (cube2);
				birds.Add (cube3);
				birds.Add (cube4);
				birds.Add (cube5);
				birds.Add (cube6);
				birds.Add (cube7);
				birds.Add (cube8);
				birds.Add (cube9);
		}
	
		// Update is called once per frame
		void Update ()
		{
				//Every few seconds, the changehealth function is called, then the timer is reset
				time = time + Time.deltaTime;
				if (time >= secondsBetweenHealthChange) {
						ChangeHealth ();
						time = 0;
				}
		}

		void ChangeHealth ()
		{
				for (int i=0; i<birds.Count; i++) {
						birds [i].gameObject.GetComponent<Cube> ().ChangeHealth ();
				}
//				cube1.gameObject.GetComponent<Cube> ().ChangeHealth ();
//				cube2.gameObject.GetComponent<Cube> ().ChangeHealth ();
//				cube3.gameObject.GetComponent<Cube> ().ChangeHealth ();
//				cube4.gameObject.GetComponent<Cube> ().ChangeHealth ();
//				cube5.gameObject.GetComponent<Cube> ().ChangeHealth ();
//				cube6.gameObject.GetComponent<Cube> ().ChangeHealth ();
//				cube7.gameObject.GetComponent<Cube> ().ChangeHealth ();
//				cube8.gameObject.GetComponent<Cube> ().ChangeHealth ();
//				cube9.gameObject.GetComponent<Cube> ().ChangeHealth ();
		}

		public void MoveCubeToFront (int cubeToMoveForward, int spotVacated)
		{
				if (cubeToMoveForward != 5) {
						iTween.MoveTo (birds [cubeToMoveForward - 1], iTween.Hash ("path", iTweenPath.GetPath (cubeToMoveForward + "to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
				} else {
						iTween.MoveTo (birds [cubeToMoveForward - 1], iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
				}


				MoveFrontBackToPosition (spotVacated);
				cubeInFront = cubeToMoveForward;
				birds [cubeToMoveForward - 1].GetComponent<Cube> ().SetPosition (5);
		}
	
		public void MoveFrontBackToPosition (int vacatedPosition)
		{
				if (vacatedPosition != 5) {
						iTween.MoveTo (birds [cubeInFront - 1], iTween.Hash ("path", iTweenPath.GetPath ("5to" + vacatedPosition), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
				} else {
						//iTween.MoveTo (birds [cubeInFront - 1], iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));

						//do nothing because you can't click on the front bird
				}
				birds [cubeInFront - 1].GetComponent<Cube> ().SetPosition (vacatedPosition);
		}
}