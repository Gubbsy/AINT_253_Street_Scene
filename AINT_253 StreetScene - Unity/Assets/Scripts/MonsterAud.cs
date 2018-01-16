using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAud : MonoBehaviour {

    public GameObject PlayerAudioManager;
    private PlayerAudioVisual playerAudio;
    private bool isTriggered;

    public GameObject monster;
    private AudioSource monsterSparks;
    public GameObject brokenLight;
    private AudioSource lightSparks;
   


    // Use this for initialization
    void Start()
    {
        playerAudio = PlayerAudioManager.GetComponent<PlayerAudioVisual>();
        monsterSparks = monster.GetComponent<AudioSource>();
        lightSparks = brokenLight.GetComponent<AudioSource>();
        isTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !isTriggered)
        {
            playerAudio.PlayMonsterMonoPlayer();
            lightSparks.Play();
            monsterSparks.Play();
            isTriggered = true;
        }
    }

}
