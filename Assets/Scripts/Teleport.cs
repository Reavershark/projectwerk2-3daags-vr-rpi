using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject teleporter;
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}

    public void StartTeleport () {
        player.GetComponent<Transform>().position = teleporter.GetComponent<Transform>().position;
    }
}