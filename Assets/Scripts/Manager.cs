using UnityEngine;
using System.Collections;

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
	
		// Use this for initialization
		void Start ()
		{
				cubeInFront = 5;
		}
	
		// Update is called once per frame
		void Update ()
		{
				time = time + Time.deltaTime;
				if (time >= secondsBetweenHealthChange) {
						ChangeHealth ();
						time = 0;
				}
		}

		void ChangeHealth ()
		{
				cube1.gameObject.GetComponent<Cube> ().ChangeHealth ();
				cube2.gameObject.GetComponent<Cube> ().ChangeHealth ();
				cube3.gameObject.GetComponent<Cube> ().ChangeHealth ();
				cube4.gameObject.GetComponent<Cube> ().ChangeHealth ();
				cube5.gameObject.GetComponent<Cube> ().ChangeHealth ();
				cube6.gameObject.GetComponent<Cube> ().ChangeHealth ();
				cube7.gameObject.GetComponent<Cube> ().ChangeHealth ();
				cube8.gameObject.GetComponent<Cube> ().ChangeHealth ();
				cube9.gameObject.GetComponent<Cube> ().ChangeHealth ();
		}
		public void MoveCubeToFront (int cubeToMoveForward, int spotVacated)
		{

				if (cubeToMoveForward == 1) {
						if (spotVacated == 1) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("1to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 2) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("2to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 3) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("3to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 4) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("4to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 5) {
								iTween.MoveTo (cube1, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 6) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("6to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 7) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("7to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 8) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("8to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 9) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("9to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 1;
						cube1.GetComponent<Cube> ().SetPosition (5);
				}

				if (cubeToMoveForward == 2) {
						if (spotVacated == 1) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("1to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 2) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("2to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 3) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("3to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 4) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("4to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 5) {
								iTween.MoveTo (cube2, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 6) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("6to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 7) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("7to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 8) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("8to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 9) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("9to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 2;
						cube2.GetComponent<Cube> ().SetPosition (5);
				}
		
				if (cubeToMoveForward == 3) {
						if (spotVacated == 1) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("1to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 2) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("2to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 3) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("3to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 4) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("4to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 5) {
								iTween.MoveTo (cube3, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 6) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("6to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 7) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("7to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 8) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("8to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 9) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("9to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 3;
						cube3.GetComponent<Cube> ().SetPosition (5);
				}

				if (cubeToMoveForward == 4) {
						if (spotVacated == 1) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("1to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 2) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("2to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 3) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("3to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 4) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("4to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 5) {
								iTween.MoveTo (cube4, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 6) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("6to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 7) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("7to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 8) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("8to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 9) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("9to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 4;
						cube4.GetComponent<Cube> ().SetPosition (5);
				}

				if (cubeToMoveForward == 5) {
						if (spotVacated == 1) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("1to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 2) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("2to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 3) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("3to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 4) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("4to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 5) {
								iTween.MoveTo (cube5, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 6) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("6to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 7) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("7to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 8) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("8to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 9) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("9to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 5;
						cube5.GetComponent<Cube> ().SetPosition (5);
				}

				if (cubeToMoveForward == 6) {
						if (spotVacated == 1) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("1to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 2) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("2to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 3) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("3to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 4) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("4to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 5) {
								iTween.MoveTo (cube6, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 6) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("6to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 7) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("7to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 8) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("8to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 9) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("9to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 6;
						cube6.GetComponent<Cube> ().SetPosition (5);
				}

				if (cubeToMoveForward == 7) {
						if (spotVacated == 1) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("1to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 2) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("2to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 3) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("3to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 4) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("4to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 5) {
								iTween.MoveTo (cube7, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 6) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("6to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 7) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("7to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 8) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("8to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 9) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("9to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 7;
						cube7.GetComponent<Cube> ().SetPosition (5);
				}

				if (cubeToMoveForward == 8) {
						if (spotVacated == 1) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("1to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 2) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("2to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 3) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("3to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 4) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("4to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 5) {
								iTween.MoveTo (cube8, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 6) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("6to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 7) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("7to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 8) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("8to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 9) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("9to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 8;
						cube8.GetComponent<Cube> ().SetPosition (5);
				}

				if (cubeToMoveForward == 9) {
						if (spotVacated == 1) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("1to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 2) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("2to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 3) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("3to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 4) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("4to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 5) {
								iTween.MoveTo (cube9, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 6) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("6to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 7) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("7to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 8) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("8to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						if (spotVacated == 9) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("9to5"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						}
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 9;
						cube9.GetComponent<Cube> ().SetPosition (5);
				}
		}
	
		public void MoveFrontBackToPosition (int vacatedPosition)
		{
	
				if (cubeInFront == 1) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("5to1"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("5to2"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (2);
						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("5to3"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (3);
						}
						if (vacatedPosition == 4) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("5to4"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (4);
						}
						if (vacatedPosition == 5) {
								iTween.MoveTo (cube1, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (5);
						}
						if (vacatedPosition == 6) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("5to6"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (6);
						}
						if (vacatedPosition == 7) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("5to7"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (7);
						}
						if (vacatedPosition == 8) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("5to8"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (8);
						}
						if (vacatedPosition == 9) {
								iTween.MoveTo (cube1, iTween.Hash ("path", iTweenPath.GetPath ("5to9"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (9);
						}
				}
				if (cubeInFront == 2) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("5to1"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("5to2"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (2);
						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("5to3"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (3);
						}
						if (vacatedPosition == 4) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("5to4"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (4);
						}
						if (vacatedPosition == 5) {
								iTween.MoveTo (cube2, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (5);
						}
						if (vacatedPosition == 6) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("5to6"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (6);
						}
						if (vacatedPosition == 7) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("5to7"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (7);
						}
						if (vacatedPosition == 8) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("5to8"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (8);
						}
						if (vacatedPosition == 9) {
								iTween.MoveTo (cube2, iTween.Hash ("path", iTweenPath.GetPath ("5to9"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (9);
						}
				}

				if (cubeInFront == 3) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("5to1"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("5to2"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (2);
						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("5to3"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (3);
						}
						if (vacatedPosition == 4) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("5to4"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (4);
						}
						if (vacatedPosition == 5) {
								iTween.MoveTo (cube3, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (5);
						}
						if (vacatedPosition == 6) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("5to6"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (6);
						}
						if (vacatedPosition == 7) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("5to7"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (7);
						}
						if (vacatedPosition == 8) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("5to8"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (8);
						}
						if (vacatedPosition == 9) {
								iTween.MoveTo (cube3, iTween.Hash ("path", iTweenPath.GetPath ("5to9"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (9);
						}
				}

				if (cubeInFront == 4) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("5to1"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube4.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("5to2"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube4.GetComponent<Cube> ().SetPosition (2);
						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("5to3"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube4.GetComponent<Cube> ().SetPosition (3);
						}
						if (vacatedPosition == 4) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("5to4"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube4.GetComponent<Cube> ().SetPosition (4);
						}
						if (vacatedPosition == 5) {
								iTween.MoveTo (cube4, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube4.GetComponent<Cube> ().SetPosition (5);
						}
						if (vacatedPosition == 6) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("5to6"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube4.GetComponent<Cube> ().SetPosition (6);
						}
						if (vacatedPosition == 7) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("5to7"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube4.GetComponent<Cube> ().SetPosition (7);
						}
						if (vacatedPosition == 8) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("5to8"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube4.GetComponent<Cube> ().SetPosition (8);
						}
						if (vacatedPosition == 9) {
								iTween.MoveTo (cube4, iTween.Hash ("path", iTweenPath.GetPath ("5to9"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube4.GetComponent<Cube> ().SetPosition (9);
						}
				}
				if (cubeInFront == 5) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("5to1"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube5.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("5to2"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube5.GetComponent<Cube> ().SetPosition (2);
						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("5to3"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube5.GetComponent<Cube> ().SetPosition (3);
						}
						if (vacatedPosition == 4) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("5to4"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube5.GetComponent<Cube> ().SetPosition (4);
						}
						if (vacatedPosition == 5) {
								iTween.MoveTo (cube5, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube5.GetComponent<Cube> ().SetPosition (5);
						}
						if (vacatedPosition == 6) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("5to6"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube5.GetComponent<Cube> ().SetPosition (6);
						}
						if (vacatedPosition == 7) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("5to7"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube5.GetComponent<Cube> ().SetPosition (7);
						}
						if (vacatedPosition == 8) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("5to8"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube5.GetComponent<Cube> ().SetPosition (8);
						}
						if (vacatedPosition == 9) {
								iTween.MoveTo (cube5, iTween.Hash ("path", iTweenPath.GetPath ("5to9"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube5.GetComponent<Cube> ().SetPosition (9);
						}
				}
				if (cubeInFront == 6) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("5to1"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube6.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("5to2"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube6.GetComponent<Cube> ().SetPosition (2);
						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("5to3"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube6.GetComponent<Cube> ().SetPosition (3);
						}
						if (vacatedPosition == 4) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("5to4"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube6.GetComponent<Cube> ().SetPosition (4);
						}
						if (vacatedPosition == 5) {
								iTween.MoveTo (cube6, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube6.GetComponent<Cube> ().SetPosition (5);
						}
						if (vacatedPosition == 6) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("5to6"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube6.GetComponent<Cube> ().SetPosition (6);
						}
						if (vacatedPosition == 7) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("5to7"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube6.GetComponent<Cube> ().SetPosition (7);
						}
						if (vacatedPosition == 8) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("5to8"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube6.GetComponent<Cube> ().SetPosition (8);
						}
						if (vacatedPosition == 9) {
								iTween.MoveTo (cube6, iTween.Hash ("path", iTweenPath.GetPath ("5to9"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube6.GetComponent<Cube> ().SetPosition (9);
						}
				}

				if (cubeInFront == 7) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("5to1"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube7.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("5to2"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube7.GetComponent<Cube> ().SetPosition (2);
						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("5to3"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube7.GetComponent<Cube> ().SetPosition (3);
						}
						if (vacatedPosition == 4) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("5to4"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube7.GetComponent<Cube> ().SetPosition (4);
						}
						if (vacatedPosition == 5) {
								iTween.MoveTo (cube7, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube7.GetComponent<Cube> ().SetPosition (5);
						}
						if (vacatedPosition == 6) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("5to6"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube7.GetComponent<Cube> ().SetPosition (6);
						}
						if (vacatedPosition == 7) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("5to7"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube7.GetComponent<Cube> ().SetPosition (7);
						}
						if (vacatedPosition == 8) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("5to8"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube7.GetComponent<Cube> ().SetPosition (8);
						}
						if (vacatedPosition == 9) {
								iTween.MoveTo (cube7, iTween.Hash ("path", iTweenPath.GetPath ("5to9"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube7.GetComponent<Cube> ().SetPosition (9);
						}
				}

				if (cubeInFront == 8) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("5to1"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube8.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("5to2"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube8.GetComponent<Cube> ().SetPosition (2);
						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("5to3"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube8.GetComponent<Cube> ().SetPosition (3);
						}
						if (vacatedPosition == 4) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("5to4"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube8.GetComponent<Cube> ().SetPosition (4);
						}
						if (vacatedPosition == 5) {
								iTween.MoveTo (cube8, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube8.GetComponent<Cube> ().SetPosition (5);
						}
						if (vacatedPosition == 6) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("5to6"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube8.GetComponent<Cube> ().SetPosition (6);
						}
						if (vacatedPosition == 7) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("5to7"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube8.GetComponent<Cube> ().SetPosition (7);
						}
						if (vacatedPosition == 8) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("5to8"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube8.GetComponent<Cube> ().SetPosition (8);
						}
						if (vacatedPosition == 9) {
								iTween.MoveTo (cube8, iTween.Hash ("path", iTweenPath.GetPath ("5to9"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube8.GetComponent<Cube> ().SetPosition (9);
						}
				}
				if (cubeInFront == 9) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("5to1"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube9.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("5to2"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube9.GetComponent<Cube> ().SetPosition (2);
						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("5to3"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube9.GetComponent<Cube> ().SetPosition (3);
						}
						if (vacatedPosition == 4) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("5to4"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube9.GetComponent<Cube> ().SetPosition (4);
						}
						if (vacatedPosition == 5) {
								iTween.MoveTo (cube9, iTween.Hash ("position", position5.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube9.GetComponent<Cube> ().SetPosition (5);
						}
						if (vacatedPosition == 6) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("5to6"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube9.GetComponent<Cube> ().SetPosition (6);
						}
						if (vacatedPosition == 7) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("5to7"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube9.GetComponent<Cube> ().SetPosition (7);
						}
						if (vacatedPosition == 8) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("5to8"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube9.GetComponent<Cube> ().SetPosition (8);
						}
						if (vacatedPosition == 9) {
								iTween.MoveTo (cube9, iTween.Hash ("path", iTweenPath.GetPath ("5to9"), "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube9.GetComponent<Cube> ().SetPosition (9);
						}
				}


		}
}