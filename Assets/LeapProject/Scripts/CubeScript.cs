﻿using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
	}

}
