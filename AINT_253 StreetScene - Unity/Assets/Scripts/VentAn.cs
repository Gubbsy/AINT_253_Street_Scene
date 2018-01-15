using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentAn : MonoBehaviour {


    private Animator ventAn;

	// Use this for initialization
	void Start () {

        ventAn = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartVentAn() {
        ventAn.SetBool("Trigger", true);
    }
}
