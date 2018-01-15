using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentTeleport : MonoBehaviour {

    public GameObject player;
    public GameObject spawnPoint;
    public GameObject PlayerAudioVisaulManger;
    private PlayerAudioVisual manager;


	// Use this for initialization
	void Start () {
        manager = PlayerAudioVisaulManger.GetComponent<PlayerAudioVisual>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            manager.FadeOut();
            player.transform.position = spawnPoint.transform.position;
            manager.FadeIn();
        }
    }
}
