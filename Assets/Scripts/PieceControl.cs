using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceControl : MonoBehaviour {

	IDictionary<string, Vector3> locations = new Dictionary<string, Vector3>(){
		{"A1", new Vector3(0.0f, 4.5f, 0.0f)}, // If y = 0, then piece is in the board. This moves it up so that it's on the board
		{"A2", new Vector3(0.0f, 4.5f, 10.0f)},
		{"A3", new Vector3(0.0f, 4.5f, 20.0f)},
		{"A4", new Vector3(0.0f, 4.5f, 30.0f)},
		{"A5", new Vector3(0.0f, 4.5f, 40.0f)},
		{"A6", new Vector3(0.0f, 4.5f, 50.0f)},
		{"A7", new Vector3(0.0f, 4.5f, 60.0f)},
		{"A8", new Vector3(0.0f, 4.5f, 70.0f)},
		{"B1", new Vector3(10.0f, 4.5f, 0.0f)},
		{"B2", new Vector3(10.0f, 4.5f, 10.0f)},
		{"B3", new Vector3(10.0f, 4.5f, 20.0f)},
		{"B4", new Vector3(10.0f, 4.5f, 30.0f)},
		{"B5", new Vector3(10.0f, 4.5f, 40.0f)},
		{"B6", new Vector3(10.0f, 4.5f, 50.0f)},
		{"B7", new Vector3(10.0f, 4.5f, 60.0f)},
		{"B8", new Vector3(10.0f, 4.5f, 70.0f)},
		{"C1", new Vector3(20.0f, 4.5f, 0.0f)},
		{"C2", new Vector3(20.0f, 4.5f, 10.0f)},
		{"C3", new Vector3(20.0f, 4.5f, 20.0f)},
		{"C4", new Vector3(20.0f, 4.5f, 30.0f)},
		{"C5", new Vector3(20.0f, 4.5f, 40.0f)},
		{"C6", new Vector3(20.0f, 4.5f, 50.0f)},
		{"C7", new Vector3(20.0f, 4.5f, 60.0f)},
		{"C8", new Vector3(20.0f, 4.5f, 70.0f)},
		{"D1", new Vector3(30.0f, 4.5f, 0.0f)},
		{"D2", new Vector3(30.0f, 4.5f, 10.0f)},
		{"D3", new Vector3(30.0f, 4.5f, 20.0f)},
		{"D4", new Vector3(30.0f, 4.5f, 30.0f)},
		{"D5", new Vector3(30.0f, 4.5f, 40.0f)},
		{"D6", new Vector3(30.0f, 4.5f, 50.0f)},
		{"D7", new Vector3(30.0f, 4.5f, 60.0f)},
		{"D8", new Vector3(30.0f, 4.5f, 70.0f)},
		{"E1", new Vector3(40.0f, 4.5f, 0.0f)},
		{"E2", new Vector3(40.0f, 4.5f, 10.0f)},
		{"E3", new Vector3(40.0f, 4.5f, 20.0f)},
		{"E4", new Vector3(40.0f, 4.5f, 30.0f)},
		{"E5", new Vector3(40.0f, 4.5f, 40.0f)},
		{"E6", new Vector3(40.0f, 4.5f, 50.0f)},
		{"E7", new Vector3(40.0f, 4.5f, 60.0f)},
		{"E8", new Vector3(40.0f, 4.5f, 70.0f)},
		{"F1", new Vector3(50.0f, 4.5f, 0.0f)},
		{"F2", new Vector3(50.0f, 4.5f, 10.0f)},
		{"F3", new Vector3(50.0f, 4.5f, 20.0f)},
		{"F4", new Vector3(50.0f, 4.5f, 30.0f)},
		{"F5", new Vector3(50.0f, 4.5f, 40.0f)},
		{"F6", new Vector3(50.0f, 4.5f, 50.0f)},
		{"F7", new Vector3(50.0f, 4.5f, 60.0f)},
		{"F8", new Vector3(50.0f, 4.5f, 70.0f)},
		{"G1", new Vector3(60.0f, 4.5f, 0.0f)},
		{"G2", new Vector3(60.0f, 4.5f, 10.0f)},
		{"G3", new Vector3(60.0f, 4.5f, 20.0f)},
		{"G4", new Vector3(60.0f, 4.5f, 30.0f)},
		{"G5", new Vector3(60.0f, 4.5f, 40.0f)},
		{"G6", new Vector3(60.0f, 4.5f, 50.0f)},
		{"G7", new Vector3(60.0f, 4.5f, 60.0f)},
		{"G8", new Vector3(60.0f, 4.5f, 70.0f)},
		{"H1", new Vector3(70.0f, 4.5f, 0.0f)},
		{"H2", new Vector3(70.0f, 4.5f, 10.0f)},
		{"H3", new Vector3(70.0f, 4.5f, 20.0f)},
		{"H4", new Vector3(70.0f, 4.5f, 30.0f)},
		{"H5", new Vector3(70.0f, 4.5f, 40.0f)},
		{"H6", new Vector3(70.0f, 4.5f, 50.0f)},
		{"H7", new Vector3(70.0f, 4.5f, 60.0f)},
		{"H8", new Vector3(70.0f, 4.5f, 70.0f)}
		};

		public string test = "Hi";

	public void goTo (string square) {
		transform.position = locations[square];
	}

	public void testAllSquares () {
		foreach (KeyValuePair<string, Vector3> square in locations) {
			goTo(square.Key);
		}
	}

	// Use this for initialization
	void Start () {
		// testAllSquares();
	}

	// Update is called once per frame
	void Update () {

	}
}
