using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeNode : MonoBehaviour
{

	public Vector3 position;
	public Vector3 face;
	public GameObject item = null;

    //Six booleans instead of four to avoid ambiguity of which dimension is west/east/north whatever.
    //Each node ignores two booleans because it ignores one dimension
    public bool[] walls = { true, true, true, true, true, true};

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
