using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{
		public GameObject cube1;
		public GameObject cube2;
		public GameObject cube3;
		public int cubeInFront;
		public GameObject position1;
		public GameObject position2;
		public GameObject position3;

		// Use this for initialization
		void Start ()
		{
				cubeInFront = 2;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void MoveCubeToFront (int cubeToMoveForward, int spotVacated)
		{
				if (cubeToMoveForward == 1) {
						iTween.MoveTo (cube1, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						MoveFrontBackToPosition (spotVacated);
						cube1.GetComponent<Cube> ().SetPosition (2);

						cubeInFront = 1;
				}

				if (cubeToMoveForward == 2) {
						iTween.MoveTo (cube2, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 2;
						cube2.GetComponent<Cube> ().SetPosition (2);

				}
		
				if (cubeToMoveForward == 3) {
						iTween.MoveTo (cube3, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
						MoveFrontBackToPosition (spotVacated);
						cubeInFront = 3;
						cube3.GetComponent<Cube> ().SetPosition (2);

				}
		}
	
		public void MoveFrontBackToPosition (int vacatedPosition)
		{
	
				if (cubeInFront == 1) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube1, iTween.Hash ("position", position1.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (1);
						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube1, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (2);

						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube1, iTween.Hash ("position", position3.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube1.GetComponent<Cube> ().SetPosition (3);

						}
				}
				if (cubeInFront == 2) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube2, iTween.Hash ("position", position1.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (1);

						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube2, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (2);

						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube2, iTween.Hash ("position", position3.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube2.GetComponent<Cube> ().SetPosition (3);

						}
				}

				if (cubeInFront == 3) {
						if (vacatedPosition == 1) {
								iTween.MoveTo (cube3, iTween.Hash ("position", position1.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (1);

						}
						if (vacatedPosition == 2) {
								iTween.MoveTo (cube3, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (2);

						}
						if (vacatedPosition == 3) {
								iTween.MoveTo (cube3, iTween.Hash ("position", position3.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
								cube3.GetComponent<Cube> ().SetPosition (3);

						}
				}
		}
}