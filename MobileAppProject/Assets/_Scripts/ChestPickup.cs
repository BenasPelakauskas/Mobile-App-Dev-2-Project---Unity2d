using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestPickup : MonoBehaviour
{
    public AudioClip _sound;    // Audio if chest is collected
    private AudioSource audio;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if(player != null)
        {
            audio.Play(); // play audio
            Destroy(gameObject, 1.5f); // Chest dissapears when player touches it
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>(); //adds audio
        audio.playOnAwake = false;
        audio.clip = _sound;
        audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
