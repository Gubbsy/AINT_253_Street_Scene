using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogsAud : MonoBehaviour {

    public GameObject PlayerAudioManager;
    private PlayerAudioVisual playerAudio;
    public Text presseE;
    private bool inRange;


    // Use this for initialization
    void Start()
    {
        playerAudio = PlayerAudioManager.GetComponent<PlayerAudioVisual>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            playerAudio.PlayLogMono();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            presseE.text = "Press 'E' to inspect";
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
