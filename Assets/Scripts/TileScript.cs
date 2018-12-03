using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

	// public PawnControl piece;
	public GameObject piece_ref;
	public PawnControl piece;

	// Use this for initialization
	void Start () {
		piece_ref = GameObject.Find("/Pawn");
		piece = (PawnControl) piece_ref.GetComponent(typeof(PawnControl));
		// piece.testAllSquares();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown () {
		Debug.Log(gameObject.name);
		piece.goTo(gameObject.name);
		// piece.testAllSquares();
	}
}
