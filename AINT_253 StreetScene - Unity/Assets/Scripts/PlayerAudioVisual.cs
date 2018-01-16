using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;


public class PlayerAudioVisual : MonoBehaviour {

    public AudioClip[] clips;
    public AudioSource source;
    private bool isPlaying;
    public Image blackScreen;
    public GameObject player;
    private FirstPersonController controller;
    public Text UIText;


    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        controller = player.GetComponent<FirstPersonController>();
        controller.enabled = false;
        UIText.text = "[ Explore the factory and Search for clues ! ]";

        PlayIntro();
	}
	
	// Update is called once per frame
	void Update () {
        isPlaying = source.isPlaying;

        if (isPlaying == false && source.clip == clips[0])
        {
            UIText.text = "";
            FadeIn();
            source.clip = clips[1];
            controller.enabled = true;

        }

        if (isPlaying == false && source.clip == clips[5])
        {
            PlayMonsterMono();
        }

        if (isPlaying == false && source.clip == clips[6]) {
            UIText.text = " ... You where o b s o r b e d ( Press 'Esc' to exit )";
            if (Input.GetKeyDown(KeyCode.Escape))
                Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(0);
        }

    }

    public void PlayIntro() {
        source.clip = clips[0];
        source.Play();
    }

    public void PlayVentMono() {
        source.clip = clips[2];
        source.Play();
    }

    public void PlayLogMono() {
        source.clip = clips[3];
        source.Play();
    }

    public void PlayRubbishMono() {
        source.clip = clips[4];
        source.Play();
    }

    public void PlayControlMonoLof() {
        source.clip = clips[1];
        source.Play();
    }

    public void PlayMonsterMonoPlayer() {
        source.clip = clips[5];
        source.Play();
    }

    public void PlayMonsterMono() {
        source.clip = clips[6];
        source.Play();
        FadeOut();
    }

    public void FadeIn() {
        StartCoroutine(FadeImage(true));
    }

    public void FadeOut() {
        StartCoroutine(FadeImage(false));
    }


    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 2; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                blackScreen.color = new Color(0, 0, 0, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            Debug.Log("Fade out called");
            // loop over 1 second
            for (float i = 2; i <= 2; i += Time.deltaTime)
            {
                // set color with i as alpha
                blackScreen.color = new Color(0, 0, 0, i);
                yield return null;
            }
        }
    }

}
