using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentAn : MonoBehaviour {

    private AudioSource ventOpen;
    private Animator ventAn;
    private bool audioPlayed;

	// Use this for initialization
	void Start () {

        ventAn = gameObject.GetComponent<Animator>();
        ventOpen = gameObject.GetComponent<AudioSource>();
        audioPlayed = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartVentAn() {
        ventAn.SetBool("Trigger", true);
        if (audioPlayed == false) {
            ventOpen.Play();
            audioPlayed = true;
        }
        
    }
}
