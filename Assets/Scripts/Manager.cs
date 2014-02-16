using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{
		public GameObject cube1;
		public GameObject cube2;
		public GameObject cube3;
		public GameObject selectedCube;
		public GameObject position1;
		public GameObject position2;
		public GameObject position3;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void MoveCubeToFront (int cubeToMove)
		{
				if (cubeToMove == 1) {
						iTween.MoveTo (cube1, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
				}

				if (cubeToMove == 2) {
						iTween.MoveTo (cube2, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
				}

				if (cubeToMove == 3) {
						iTween.MoveTo (cube3, iTween.Hash ("position", position2.transform.position, "easetype", iTween.EaseType.easeInOutSine, "time", 2f));
				}
		}
}
