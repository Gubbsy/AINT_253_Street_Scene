using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContolerAn : MonoBehaviour {

    public GameObject handle;
    public GameObject vent;
    private Animator handleAnimator;

    private VentAn ventAn;
    public Text presseE;
    private bool inRange;

    public GameObject PlayerAudioManager;
    private PlayerAudioVisual playerAudio;

    // Use this for initialization
    void Start()
    {
        handleAnimator = GetComponent<Animator>();
        ventAn = vent.GetComponent<VentAn>();
        playerAudio = PlayerAudioManager.GetComponent<PlayerAudioVisual>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            handleAnimator.SetBool("Trigger", true);
            ventAn.StartVentAn();
            playerAudio.PlayControlMonoLof();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            presseE.text = "Press 'E' ";
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            presseE.text = "";
            inRange = false;
        }
    }
}
